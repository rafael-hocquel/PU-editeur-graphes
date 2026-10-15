namespace GraphDrawing
{
    partial class GraphDrawing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphDrawing));
            toolStrip1 = new ToolStrip();
            moveModeToolStripButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            shrinkToolStripButton = new ToolStripButton();
            growToolStripButton = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            nodeWidthToolbarLabel = new ToolStripLabel();
            nodeColorToolStripButton = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            eraseGraph = new ToolStripButton();
            toolStripUndoButton = new ToolStripButton();
            toolStripRedoButton = new ToolStripButton();
            vScrollBar1 = new VScrollBar();
            hScrollBar1 = new HScrollBar();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            copyToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { moveModeToolStripButton, toolStripSeparator3, shrinkToolStripButton, growToolStripButton, toolStripSeparator4, nodeWidthToolbarLabel, nodeColorToolStripButton, toolStripSeparator5, eraseGraph, toolStripUndoButton, toolStripRedoButton });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 38);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // moveModeToolStripButton
            // 
            moveModeToolStripButton.CheckOnClick = true;
            moveModeToolStripButton.Image = (Image)resources.GetObject("moveModeToolStripButton.Image");
            moveModeToolStripButton.ImageTransparentColor = Color.Magenta;
            moveModeToolStripButton.Name = "moveModeToolStripButton";
            moveModeToolStripButton.Size = new Size(75, 35);
            moveModeToolStripButton.Text = "Move Mode";
            moveModeToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            moveModeToolStripButton.ToolTipText = "Toggles Move Node Mode";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 38);
            // 
            // shrinkToolStripButton
            // 
            shrinkToolStripButton.Image = (Image)resources.GetObject("shrinkToolStripButton.Image");
            shrinkToolStripButton.ImageTransparentColor = Color.Magenta;
            shrinkToolStripButton.Name = "shrinkToolStripButton";
            shrinkToolStripButton.Size = new Size(23, 35);
            shrinkToolStripButton.Text = "-";
            shrinkToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            shrinkToolStripButton.ToolTipText = "Reduce node size";
            shrinkToolStripButton.Click += ShrinkToolStripButton_Click;
            // 
            // growToolStripButton
            // 
            growToolStripButton.Image = (Image)resources.GetObject("growToolStripButton.Image");
            growToolStripButton.ImageTransparentColor = Color.Magenta;
            growToolStripButton.Name = "growToolStripButton";
            growToolStripButton.Size = new Size(23, 35);
            growToolStripButton.Text = "+";
            growToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            growToolStripButton.ToolTipText = "Increase node size";
            growToolStripButton.Click += GrowToolStripButton_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 38);
            // 
            // nodeWidthToolbarLabel
            // 
            nodeWidthToolbarLabel.Name = "nodeWidthToolbarLabel";
            nodeWidthToolbarLabel.Size = new Size(71, 35);
            nodeWidthToolbarLabel.Text = "Node Width";
            // 
            // nodeColorToolStripButton
            // 
            nodeColorToolStripButton.Image = (Image)resources.GetObject("nodeColorToolStripButton.Image");
            nodeColorToolStripButton.ImageTransparentColor = Color.Magenta;
            nodeColorToolStripButton.Name = "nodeColorToolStripButton";
            nodeColorToolStripButton.Size = new Size(38, 35);
            nodeColorToolStripButton.Text = "color";
            nodeColorToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            nodeColorToolStripButton.ToolTipText = "Change node color";
            nodeColorToolStripButton.Click += NodeColorToolStripButton_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 38);
            // 
            // eraseGraph
            // 
            eraseGraph.Image = (Image)resources.GetObject("eraseGraph.Image");
            eraseGraph.ImageTransparentColor = Color.Magenta;
            eraseGraph.Name = "eraseGraph";
            eraseGraph.Size = new Size(87, 35);
            eraseGraph.Text = "Erase all graph";
            eraseGraph.TextImageRelation = TextImageRelation.ImageAboveText;
            eraseGraph.Click += EraseGraph_Click;
            // 
            // toolStripUndoButton
            // 
            toolStripUndoButton.Image = (Image)resources.GetObject("toolStripUndoButton.Image");
            toolStripUndoButton.ImageTransparentColor = Color.Magenta;
            toolStripUndoButton.Name = "toolStripUndoButton";
            toolStripUndoButton.Size = new Size(40, 35);
            toolStripUndoButton.Text = "Undo";
            toolStripUndoButton.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripUndoButton.ToolTipText = "Undo Last Action";
            // 
            // toolStripRedoButton
            // 
            toolStripRedoButton.Image = (Image)resources.GetObject("toolStripRedoButton.Image");
            toolStripRedoButton.ImageTransparentColor = Color.Magenta;
            toolStripRedoButton.Name = "toolStripRedoButton";
            toolStripRedoButton.Size = new Size(38, 35);
            toolStripRedoButton.Text = "Redo";
            toolStripRedoButton.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripRedoButton.ToolTipText = "Redo Last Action";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.LargeChange = 50;
            vScrollBar1.Location = new Point(772, 62);
            vScrollBar1.Maximum = 800;
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(28, 388);
            vScrollBar1.SmallChange = 4;
            vScrollBar1.TabIndex = 1;
            vScrollBar1.Scroll += VScroll_Scroll;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Dock = DockStyle.Bottom;
            hScrollBar1.LargeChange = 50;
            hScrollBar1.Location = new Point(0, 423);
            hScrollBar1.Maximum = 800;
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(772, 27);
            hScrollBar1.SmallChange = 4;
            hScrollBar1.TabIndex = 2;
            hScrollBar1.Scroll += HScroll_Scroll;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, settingsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator1, copyToolStripMenuItem, cutToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator2, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(180, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += UndoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(180, 22);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += RedoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(180, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(180, 22);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(180, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(180, 22);
            selectAllToolStripMenuItem.Text = "Select All";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // GraphDrawing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hScrollBar1);
            Controls.Add(vScrollBar1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "GraphDrawing";
            Text = "GraphDrawing";
            Paint += GraphDrawing_Paint;
            MouseDown += GraphDrawing_MouseDown;
            MouseMove += GraphDrawing_MouseMove;
            MouseUp += GraphDrawing_MouseUp;
            MouseWheel += MainWindow_MouseWheel;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton moveModeToolStripButton;
        private ToolStripButton shrinkToolStripButton;
        private ToolStripButton growToolStripButton;
        private ToolStripButton eraseGraph;
        private ToolStripLabel nodeWidthToolbarLabel;
        private ToolStripButton nodeColorToolStripButton;
        private VScrollBar vScrollBar1;
        private HScrollBar hScrollBar1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripUndoButton;
        private ToolStripButton toolStripRedoButton;
    }
}
