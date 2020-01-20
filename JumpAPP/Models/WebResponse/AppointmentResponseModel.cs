using System;
using System.Collections.Generic;
using System.Text;

namespace JumpAPP.Models.WebResponse
{
    public class AppointmentResponseModel
    {
        public bool IS_COPY { get; set; }
        public bool PJ_LONTANO { get; set; }
        public bool PJ_PERNOTTA { get; set; }
        public bool PJ_PEDAGGIO_PAGATO { get; set; }
        public bool PJ_VITTO_PAGATO { get; set; }
        public bool PJ_ALLOGGIO_PAGATO { get; set; }
        public bool PJ_ALTRO_PAGATO { get; set; }
        public bool PJ_VIAGGIO_PAGATO { get; set; }
        public bool PJ_CARBURANTE_PAGATO { get; set; }
        public bool COSTO_LONTANO_PAGATO { get; set; }
        public bool COSTO_PERNOTTAMENTO_PAGATO { get; set; }
        public double ID_AGENDA { get; set; }
        public string NOMEAZIENDA { get; set; }
        public string SOGGETTO { get; set; }
        public string NOTE { get; set; }
        public string USERNAME { get; set; }
        public double LABEL { get; set; }
        public string DESCR_LABEL { get; set; }
        public string FIRMA { get; set; }
        public string DESCR_USERNAME { get; set; }
        public double STATO { get; set; }
        public string DESCR_STATO { get; set; }
        public DateTime STARTIME { get; set; }
        public DateTime ENDTIME { get; set; }
        public bool ALLDAY { get; set; }
        public double OREdouble { get; set; }
        public double OREFATT { get; set; }
        public double KM { get; set; }
        public double SPESE_VA_AGE { get; set; }
        public double RIMBORSI_OPE { get; set; }
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
        public double? ID_ANAGEN { get; set; }
        public string LOCATION { get; set; }
        public double? ID_ANAGEN_INDIR { get; set; }
    }
}
