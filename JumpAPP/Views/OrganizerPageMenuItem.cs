using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JumpAPP.Views
{

    public class OrganizerPageMenuItem
    {
        public OrganizerPageMenuItem()
        {
            TargetType = typeof(OrganizerPageDetail);
            TargetType = typeof(WeekdayPage);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public Color BackgroundColor { get; set; }

        public Type TargetType { get; set; }
    }
}