using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cardville.Dungeon.WFViewController
{
    public partial class GameLevelForm : Form
    {
        public GameLevelForm()
        {
            InitializeComponent();
            Game game = new Game("Hellou Man");
            this.WindowState = FormWindowState.Maximized;

            DungeonPainter dungeonPainter = new DungeonPainter(game);
            dungeonPainter.GetControl().Size = new Size(1920, 1080);
            this.Controls.Add(dungeonPainter.GetControl());

            InventoryPainter inventoryPainter = new InventoryPainter(game.Player.Inventory, 3);
            inventoryPainter.GetControl().Size = new Size(1920, 1080);
            inventoryPainter.GetControl().Location = new Point(960, 0);
            this.Controls.Add(inventoryPainter.GetControl());
        }
    }
}
