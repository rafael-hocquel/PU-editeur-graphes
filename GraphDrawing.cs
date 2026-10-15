namespace GraphDrawing
{
    public partial class GraphDrawing : Form
    {
        private readonly Stack<GraphAction> actionStack = new(50);
        private readonly Stack<GraphAction> undoneStack = new(50);
        private readonly List<Node> nodes;
        private readonly List<Line> lines;
        private bool moving = false;
        private bool drawingLines = false;
        private Node? selection;
        private Node? contextSelection;
        private Point mousePosition;
        private Point movingOffset;
        private ContextMenuStrip nodeContextMenu;
        private Color originalNodeColor;

        // Enum qui indique le mode de modification de la taille du noeud (lorque l'on veut le changer depuis la toolbar)
        private enum EditNodeSizeMode
        {
            Shrink, Grow
        }

        public enum GraphActionType
        {
            Create, Delete, Move, Change
        }

        public GraphDrawing()
        {
            InitializeComponent();
            nodes = [];
            lines = [];

            #region Set Labels
            nodeColorToolStripButton.Text = Settings.BaseNodeColor.IsKnownColor ? Settings.BaseNodeColor.ToKnownColor().ToString() : "#" + Settings.BaseNodeColor.Name;
            nodeWidthToolbarLabel.Text = "Node width: " + Settings.BaseNodeWidth;
            #endregion

            #region Create context Menu
            nodeContextMenu = new ContextMenuStrip();
            foreach (string item in new string[] { "Delete", "Change" })
            {
                ToolStripMenuItem toolStripMenuItem = new(item);
                toolStripMenuItem.Click += ToolStripMenuItem_Click;
                nodeContextMenu.Items.Add(toolStripMenuItem);
            }
            #endregion

        }

        private void GraphDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            selection = Selected(e.Location);
            if (moveModeToolStripButton.Checked)
            {
                #region Move Node
                moving = selection != null;
                if (selection != null)
                {
                    originalNodeColor = selection.Color;
                    selection.Color = Color.Red;
                    Point geometryLocation = Outils.ScreenToGeometry(e.Location);
                    movingOffset = new Point(geometryLocation.X - selection.Location.X, geometryLocation.Y - selection.Location.Y);
                    Refresh();
                }
                #endregion
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (selection == null)
                    {
                        #region Create Node
                        Node newNode = (new() { Location = Outils.ScreenToGeometry(e.Location), Width = Settings.BaseNodeWidth, Color = Settings.BaseNodeColor });
                        nodes.Add(newNode);
                        GraphAction a = new() { Subject = newNode, Type = GraphActionType.Create };
                        actionStack.Push(a);
                        Refresh();
                        #endregion
                    }
                    else
                    {
                        drawingLines = true;
                        mousePosition = e.Location;
                    }
                }
                else
                {
                    #region Context Menu
                    if (selection != null)
                    {
                        contextSelection = selection;
                        nodeContextMenu.Show(this, e.Location);

                    }
                    #endregion
                }

            }
        }

        private void ToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (contextSelection != null)
            {
                switch ((sender as ToolStripMenuItem)?.Text)
                {
                    case "Delete":
                        {
                            #region Delete Node
                            contextSelection.Deleted = true;
                            Refresh();
                            break;
                            #endregion
                        }
                        ;
                    case "Change":
                        {
                            #region Change Node Settings
                            NodeSettings settings = new(contextSelection.Color, contextSelection.Width, contextSelection.Text);
                            if (settings.ShowDialog() == DialogResult.OK)
                            {
                                contextSelection.Text = settings.Text;
                                contextSelection.Color = settings.Color;
                                contextSelection.Width = settings.Width;
                                contextSelection = null;
                                Refresh();
                            }
                            break;
                            #endregion
                        }

                    default: return;
                }
            }
            contextSelection = null;
        }

        private void GraphDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            // Ce noeud est utilisé pour le noeud de fin d'une ligne ET pour changer la couleur du noeud en rouge lors du déplacement
            Node? endNode = Selected(e.Location);
            if (moving)
            {
                // Remettre le noeud de sa couleur originale
                if (endNode != null)
                {
                    endNode.Color = originalNodeColor;
                    Refresh();
                }
                moving = false;
            }
            if (drawingLines)
                drawingLines = false;

            #region Draw Line (and add node)
            if (endNode != null && selection != null && !endNode.Equals(selection))
            {
                Line newLine = new()
                {
                    Start = selection,
                    End = endNode
                };
                GraphAction action1 = new() { Subject = newLine, Type = GraphActionType.Create };
                lines.Add(newLine);
                actionStack.Push(action1);
            }
            else if (endNode == null && selection != null)
            {
                // Node
                nodes.Add(new() { Location = Outils.ScreenToGeometry(e.Location), Color = Settings.BaseNodeColor, Width = Settings.BaseNodeWidth });
                Node newNode = nodes[nodes.Count - 1];
                GraphAction a = new() { Subject = newNode, Type = GraphActionType.Create };
                actionStack.Push(a);

                // Line
                Line newLine = new()
                {
                    Start = selection,
                    End = newNode,
                };
                GraphAction action1 = new() { Subject = newLine, Type = GraphActionType.Create };
                lines.Add(newLine);
                actionStack.Push(action1);
                #endregion
                Refresh();
            }
        }


        private void GraphDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                Point geometryLocation = Outils.ScreenToGeometry(e.Location);
                selection?.Move(new Point(geometryLocation.X - movingOffset.X, geometryLocation.Y - movingOffset.Y));
                Refresh();
            }

            if (drawingLines)
            {
                mousePosition = e.Location;
                Refresh();
            }
        }

        private void GraphDrawing_Paint(object sender, PaintEventArgs e)
        {
            foreach (Node n in nodes)
            {
                n.Draw(e.Graphics);
            }

            foreach (Line line in lines)
            {
                line.Draw(e.Graphics);
            }

            if (drawingLines && selection != null)
            {
                Pen p = new Pen(Color.Black);
                Point lineStartGeometry = Outils.GeometryToScreen(selection.Centre);
                e.Graphics.DrawLine(p, lineStartGeometry, mousePosition);

            }
        }

        private Node? Selected(Point p)
        {
            Node? res = null;
            int i = 0;
            while (res == null && i < nodes.Count)
            {
                if (nodes[i].Contains(p))
                {
                    res = nodes[i];
                }
                i++;
            }
            return res;

        }

        // Fonction qui met à jour la taille des prochains noeuds
        private void SetNewNodeWidth(EditNodeSizeMode mode)
        {
            int increment = mode == EditNodeSizeMode.Shrink ? -1 : 1;
            if (Settings.BaseNodeWidth + increment < 1)
            {
                Settings.BaseNodeWidth = 1;
            }
            else if (Settings.BaseNodeWidth + increment > 10)
            {
                Settings.BaseNodeWidth = 10;
            }
            else
            {

                Settings.BaseNodeWidth = Settings.BaseNodeWidth + increment;
            }
            nodeWidthToolbarLabel.Text = "Node Width: " + Settings.BaseNodeWidth;
        }

        private void ShrinkToolStripButton_Click(object sender, EventArgs e)
        {
            SetNewNodeWidth(EditNodeSizeMode.Shrink);
        }

        private void GrowToolStripButton_Click(object sender, EventArgs e)
        {
            SetNewNodeWidth(EditNodeSizeMode.Grow);
        }

        private void EraseGraph_Click(object sender, EventArgs e)
        {
            nodes.Clear();
            lines.Clear();
            Refresh();
        }

        private void NodeColorToolStripButton_Click(object sender, EventArgs e)
        {
            ColorDialog col = new() { Color = Settings.BaseNodeColor };
            if (col.ShowDialog() == DialogResult.OK)
            {
                Settings.BaseNodeColor = col.Color;
                nodeColorToolStripButton.Text = col.Color.IsKnownColor ? col.Color.ToKnownColor().ToString() : "#" + col.Color.Name;
                nodeColorToolStripButton.ForeColor = col.Color;
            }
        }

        private void VScroll_Scroll(object sender, ScrollEventArgs e)
        {
            Settings.Origin = new(Settings.Origin.X, -e.NewValue);
            Refresh();
        }

        private void HScroll_Scroll(object sender, ScrollEventArgs e)
        {
            Settings.Origin = new(-e.NewValue, Settings.Origin.Y);
            Refresh();
        }

        public void MainWindow_MouseWheel(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                if (e.Delta > 0)
                {
                    Settings.Zoom *= Settings.Zoom >= 15 ? 1 : 1.1f;
                }

                if (e.Delta < 0)
                {
                    Settings.Zoom *= Settings.Zoom <= 0.1f ? 1 : 0.9f;
                }
                Refresh();
            }
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (actionStack.Count > 0)
            {
                GraphAction action = actionStack.Pop();
                undoneStack.Push(action);
                action.Undo();
                Refresh();
            }
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undoneStack.Count > 0)
            {
                GraphAction action = undoneStack.Pop();
                actionStack.Push(action);
                action.Redo();
                Refresh();
            }

        }
    }
}
