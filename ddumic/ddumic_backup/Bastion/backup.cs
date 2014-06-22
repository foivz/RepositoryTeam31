using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace Bastion
{
    class backup
    {
        Timer timerPocetni;
        public backup(Timer timerPar)
        {
            this.timerPocetni = timerPar;
            napraviBackup();
        }

        public void napraviBackup()
        {
            DateTime datum = DateTime.Now;
            if (datum.DayOfWeek.Equals(DayOfWeek.Monday))
            {
                //if (datum.Hour == 12)
                // {
                File.Copy(@"..\..\..\baza\PI.db", @"..\..\..\Backup\PI.db", true);
                // }
            }
            else
            {
                this.timerPocetni.Start();
            }
        }

    }
}

//klasa koja radi backup...sprema backup baze u drugu lokaciju
