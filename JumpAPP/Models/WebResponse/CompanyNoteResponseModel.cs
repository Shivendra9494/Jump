using System;
using System.Collections.Generic;
using System.Text;

namespace JumpAPP.Models.WebResponse
{
    public class CompanyNoteResponseModel
    {
        public int ID_ANAGEN { get; set; }
        public double K2_ID_RIGA { get; set; }
        public string TIPO_NOTA { get; set; }
        public string RESP_RIGA { get; set; }
        public string NOTE { get; set; }
        public string STATO { get; set; }
        public DateTime DATA_RIGA { get; set; }
        public DateTime DATA_SCAD { get; set; }
        public DateTime SYS_DTCREAZ { get; set; }
        public double SYS_NONMODIFICABILE { get; set; }
        public string SYS_STATO { get; set; }
        public string SYS_CHIAVEGLOBALE { get; set; }
        public double ID { get; set; }
        public bool SYNC_FLG_DaInviare { get; set; }
        public bool SYNC_FLG_Inviato { get; set; }
        public bool SYNC_FLG_DaCancellare { get; set; }
        public bool SYNC_FLG_Cancellato { get; set; }
        public bool IsModificato { get; set; }
        public bool IsCancellatoDaApp { get; set; }
        public bool IsCancellatoDaServer { get; set; }
        public bool FlgCancellazioneLogica { get; set; }
        public string SYS_OWNER { get; set; }
        public string SYS_CREATOR { get; set; }
    }
}
