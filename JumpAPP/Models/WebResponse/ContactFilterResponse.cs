using System;
using System.Collections.Generic;
using System.Text;

namespace JumpAPP.Models.WebResponse
{
    public class ContactFilterResponse
    {
        public double ID_CONTATTO { get; set; }
        public string NOME { get; set; }
        public string COGNOME { get; set; }
        public string RUOLO { get; set; }
        public string TELEF01 { get; set; }
        public string FAX01 { get; set; }
        public string MOBILE { get; set; }
        public string TELEF02 { get; set; }
        public string EMAIL { get; set; }
        public double ID_ANAGEN { get; set; }
        public bool NEWSLETTER { get; set; }
        public double K2_ANAGEN_INDIR { get; set; }
        public double OBSOLETO { get; set; }
        public double FLG_MARKETING { get; set; }
        public bool FLG_CORSO { get; set; }
        public string NOMEAZIENDA { get; set; }
        public string INDIRIZZO { get; set; }
        public List<object> AppuntamentiContatti { get; set; }
        public double SYS_NONMODIFICABILE { get; set; }
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
