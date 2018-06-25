using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Kran {
        public void HakenEin(Panel haken) {
            haken.Size = new Size(haken.Width, haken.Height + 10);
        }

        public void HakenAus(Panel haken) {
            haken.Size = new Size(haken.Width, haken.Height - 10);
        }

        public void ArmEin(Panel arm, Panel haken) {
            arm.Size = new Size(arm.Width - 10, arm.Height);
            arm.Location = new Point(arm.Location.X + 10, arm.Location.Y);
            haken.Location = new Point(haken.Location.X + 10, haken.Location.Y);
        }

        public void ArmAus(Panel arm, Panel haken) {
            arm.Size = new Size(arm.Width + 10, arm.Height);
            arm.Location = new Point(arm.Location.X - 10, arm.Location.Y);
            haken.Location = new Point(haken.Location.X - 10, haken.Location.Y);
        }

        public void BasiLinks(Panel basi, Panel arm, Panel haken, Panel high) {
            basi.Location = new Point(basi.Location.X - 10, basi.Location.Y);
            arm.Location = new Point(arm.Location.X - 10, arm.Location.Y);
            haken.Location = new Point(haken.Location.X - 10, haken.Location.Y);
            high.Location = new Point(high.Location.X - 10, high.Location.Y);
        }

        public void BasiRechts(Panel basi, Panel arm, Panel haken, Panel high) {
            basi.Location = new Point(basi.Location.X + 10, basi.Location.Y);
            arm.Location = new Point(arm.Location.X + 10, arm.Location.Y);
            haken.Location = new Point(haken.Location.X + 10, haken.Location.Y);
            high.Location = new Point(high.Location.X + 10, high.Location.Y);
        }

        public void KranAus(Panel basi, Panel arm, Panel haken, Panel high) {
            high.Location = new Point(high.Location.X, high.Location.Y - 10);
            high.Size = new Size(high.Width, high.Height + 10);
            arm.Location = new Point(arm.Location.X, arm.Location.Y - 10);
            haken.Location = new Point(haken.Location.X, haken.Location.Y - 10);
        }

        public void KranEin(Panel basi, Panel arm, Panel haken, Panel high) {
            high.Location = new Point(high.Location.X, high.Location.Y + 10);
            high.Size = new Size(high.Width, high.Height - 10);
            arm.Location = new Point(arm.Location.X, arm.Location.Y + 10);
            haken.Location = new Point(haken.Location.X, haken.Location.Y + 10);
        }
    }
}
