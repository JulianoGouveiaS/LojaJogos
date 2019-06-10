using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo.Utils
{
   public class Utilitarios
    {
        public void preencherCombo(ComboBox cb, DataTable data, string valueMember, string displayMember) {
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.DataSource = data;
            cb.ValueMember = valueMember;
            cb.DisplayMember = displayMember;
            cb.Update();
        }
    }
}
