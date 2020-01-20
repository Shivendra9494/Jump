using System;
using System.Collections.Generic;
using System.Text;

namespace JumpAPP.Models.WebRequest
{
    public class OrganiserFormRequestModel
    {
        public int ID_AGENDA { get; set; }
        public double ID_ANAGEN { get; set; }
        public string SOGGETTO { get; set; }
        public string DESCRIZIONE { get; set; }
        public double LABEL { get; set; }
        public double STATO { get; set; }
        public DateTime STARTIME { get; set; }
        public DateTime ENDTIME { get; set; }
        public double OREINT { get; set; }
        public double OREFATT { get; set; }
        public string ID_COMM { get; set; }
        public double ID_CONTATTO { get; set; }
        public double ID_ANAGEN_INDIR { get; set; }
        public double K2_FASE { get; set; }
        public string ID_TICKET { get; set; }
        public string SYS_OWNER { get; set; }
        public string SYS_CREATOR { get; set; }
        public string SYS_MODIFIEDBY { get; set; }
        public DateTime SYS_DTCREAZ { get; set; }
        public DateTime SYS_DTMOD { get; set; }
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
    }
}
