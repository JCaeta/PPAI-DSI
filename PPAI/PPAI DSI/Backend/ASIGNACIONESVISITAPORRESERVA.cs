//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPAI_DSI.Backend
{
    using System;
    using System.Collections.Generic;
    
    public partial class ASIGNACIONESVISITAPORRESERVA
    {
        public int Id_AsignacionVisitaPorReserva { get; set; }
        public Nullable<int> Id_AsignacionVisita { get; set; }
        public Nullable<int> Id_Reserva { get; set; }
    
        public virtual ASIGNACIONESVISITA ASIGNACIONESVISITA { get; set; }
        public virtual RESERVAS RESERVAS { get; set; }
    }
}
