
namespace GraphDrawing
{
    public partial class NodeSettings : Form
    {
        public NodeSettings(Color c, int w, string t)
        {
            InitializeComponent();
            nodeSettingsColorVisualizationLabel.BackColor = c;
            nodeSettingsWidthNumericUpDown.Value = w;
            nodeSettingsColorVisualizationLabel.ForeColor = c;
            nodeSettingsTextBox.Text = t;
        }

        public Color Color => nodeSettingsColorVisualizationLabel.BackColor;
        public new int Width => (int)nodeSettingsWidthNumericUpDown.Value;
        public new string Text => nodeSettingsTextBox.Text;

        private void nodeSettingsColorVisualizationLabel_Click(object sender, EventArgs e)
        {
            ColorDialog col = new() { Color = nodeSettingsColorVisualizationLabel.BackColor };
            if (col.ShowDialog() == DialogResult.OK)
            {
                nodeSettingsColorVisualizationLabel.BackColor = col.Color;
                nodeSettingsColorVisualizationLabel.ForeColor = col.Color;
            }
        }

    }
}
