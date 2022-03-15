﻿using System.ComponentModel;

namespace WinForms.Tiles
{
    public partial class Tile : UserControl
    {
        private const int SelectionFramePadding = 20;

        public Tile()
        {
            InitializeComponent();
        }

        public TileContent TileContent
        {
            get
            {
                if (_contentPanel.Controls.Count == 0)
                {
                    _contentPanel.Controls.Add(new TileContent()
                    {
                        Dock = DockStyle.Fill,
                    });
                }

                return (_contentPanel.Controls[0] as TileContent)!;
            }
            set
            {
                if (_contentPanel.Controls.Count > 0)
                {
                    _contentPanel.Controls.Clear();
                }

                var tileContent = value;
                tileContent.Dock = DockStyle.Fill;
                tileContent.Enabled = true;

                _contentPanel.Controls.Add(tileContent);
            }
        }
    }
}
