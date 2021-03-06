﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelDataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HotelTsgDBEntities : DbContext
    {
        public HotelTsgDBEntities()
            : base("name=HotelTsgDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int spCamera_Delete(Nullable<int> nr_camera)
        {
            var nr_cameraParameter = nr_camera.HasValue ?
                new ObjectParameter("nr_camera", nr_camera) :
                new ObjectParameter("nr_camera", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCamera_Delete", nr_cameraParameter);
        }
    
        public virtual ObjectResult<spCamera_GetAll_Result> spCamera_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCamera_GetAll_Result>("spCamera_GetAll");
        }
    
        public virtual ObjectResult<spCamera_GetByNumber_Result> spCamera_GetByNumber(Nullable<int> nr_camera)
        {
            var nr_cameraParameter = nr_camera.HasValue ?
                new ObjectParameter("nr_camera", nr_camera) :
                new ObjectParameter("nr_camera", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCamera_GetByNumber_Result>("spCamera_GetByNumber", nr_cameraParameter);
        }
    
        public virtual int spCamera_Insert(Nullable<int> nr_camera, Nullable<int> capacitate, Nullable<int> pret)
        {
            var nr_cameraParameter = nr_camera.HasValue ?
                new ObjectParameter("nr_camera", nr_camera) :
                new ObjectParameter("nr_camera", typeof(int));
    
            var capacitateParameter = capacitate.HasValue ?
                new ObjectParameter("capacitate", capacitate) :
                new ObjectParameter("capacitate", typeof(int));
    
            var pretParameter = pret.HasValue ?
                new ObjectParameter("pret", pret) :
                new ObjectParameter("pret", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCamera_Insert", nr_cameraParameter, capacitateParameter, pretParameter);
        }
    
        public virtual int spCamere_UpdatePrice(Nullable<int> nr_camera, Nullable<int> pret)
        {
            var nr_cameraParameter = nr_camera.HasValue ?
                new ObjectParameter("nr_camera", nr_camera) :
                new ObjectParameter("nr_camera", typeof(int));
    
            var pretParameter = pret.HasValue ?
                new ObjectParameter("pret", pret) :
                new ObjectParameter("pret", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCamere_UpdatePrice", nr_cameraParameter, pretParameter);
        }
    
        public virtual ObjectResult<spClient_GetAll_Result> spClient_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spClient_GetAll_Result>("spClient_GetAll");
        }
    
        public virtual ObjectResult<spClient_GetById_Result> spClient_GetById(Nullable<int> id_client)
        {
            var id_clientParameter = id_client.HasValue ?
                new ObjectParameter("id_client", id_client) :
                new ObjectParameter("id_client", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spClient_GetById_Result>("spClient_GetById", id_clientParameter);
        }
    
        public virtual ObjectResult<spClient_GetByName_Result> spClient_GetByName(string nume, string prenume)
        {
            var numeParameter = nume != null ?
                new ObjectParameter("nume", nume) :
                new ObjectParameter("nume", typeof(string));
    
            var prenumeParameter = prenume != null ?
                new ObjectParameter("prenume", prenume) :
                new ObjectParameter("prenume", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spClient_GetByName_Result>("spClient_GetByName", numeParameter, prenumeParameter);
        }
    
        public virtual int spClient_Insert(Nullable<int> id_client, string nume, string prenume, string telefon)
        {
            var id_clientParameter = id_client.HasValue ?
                new ObjectParameter("id_client", id_client) :
                new ObjectParameter("id_client", typeof(int));
    
            var numeParameter = nume != null ?
                new ObjectParameter("nume", nume) :
                new ObjectParameter("nume", typeof(string));
    
            var prenumeParameter = prenume != null ?
                new ObjectParameter("prenume", prenume) :
                new ObjectParameter("prenume", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("telefon", telefon) :
                new ObjectParameter("telefon", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spClient_Insert", id_clientParameter, numeParameter, prenumeParameter, telefonParameter);
        }
    
        public virtual int spDotare_camera_Insert(Nullable<int> id_dotare, Nullable<int> nr_camera)
        {
            var id_dotareParameter = id_dotare.HasValue ?
                new ObjectParameter("id_dotare", id_dotare) :
                new ObjectParameter("id_dotare", typeof(int));
    
            var nr_cameraParameter = nr_camera.HasValue ?
                new ObjectParameter("nr_camera", nr_camera) :
                new ObjectParameter("nr_camera", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDotare_camera_Insert", id_dotareParameter, nr_cameraParameter);
        }
    
        public virtual ObjectResult<spDotare_GetAll_Result> spDotare_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spDotare_GetAll_Result>("spDotare_GetAll");
        }
    
        public virtual ObjectResult<spDotare_GetById_Result> spDotare_GetById(Nullable<int> id_dotare)
        {
            var id_dotareParameter = id_dotare.HasValue ?
                new ObjectParameter("id_dotare", id_dotare) :
                new ObjectParameter("id_dotare", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spDotare_GetById_Result>("spDotare_GetById", id_dotareParameter);
        }
    
        public virtual ObjectResult<string> spDotare_GetNameRaport(Nullable<int> nr_camera)
        {
            var nr_cameraParameter = nr_camera.HasValue ?
                new ObjectParameter("nr_camera", nr_camera) :
                new ObjectParameter("nr_camera", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("spDotare_GetNameRaport", nr_cameraParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> spDotare_GetNameRaportCount(Nullable<int> nr_camera)
        {
            var nr_cameraParameter = nr_camera.HasValue ?
                new ObjectParameter("nr_camera", nr_camera) :
                new ObjectParameter("nr_camera", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spDotare_GetNameRaportCount", nr_cameraParameter);
        }
    
        public virtual int spDotare_Insert(Nullable<int> id_dotare, string denumire, Nullable<int> pret)
        {
            var id_dotareParameter = id_dotare.HasValue ?
                new ObjectParameter("id_dotare", id_dotare) :
                new ObjectParameter("id_dotare", typeof(int));
    
            var denumireParameter = denumire != null ?
                new ObjectParameter("denumire", denumire) :
                new ObjectParameter("denumire", typeof(string));
    
            var pretParameter = pret.HasValue ?
                new ObjectParameter("pret", pret) :
                new ObjectParameter("pret", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDotare_Insert", id_dotareParameter, denumireParameter, pretParameter);
        }
    
        public virtual ObjectResult<spGetDotByRoom_Result> spGetDotByRoom(Nullable<int> nr_camera)
        {
            var nr_cameraParameter = nr_camera.HasValue ?
                new ObjectParameter("nr_camera", nr_camera) :
                new ObjectParameter("nr_camera", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetDotByRoom_Result>("spGetDotByRoom", nr_cameraParameter);
        }
    
        public virtual ObjectResult<spGetRoomByDot_Result> spGetRoomByDot(Nullable<int> id_dotare)
        {
            var id_dotareParameter = id_dotare.HasValue ?
                new ObjectParameter("id_dotare", id_dotare) :
                new ObjectParameter("id_dotare", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetRoomByDot_Result>("spGetRoomByDot", id_dotareParameter);
        }
    
        public virtual ObjectResult<spRezervare_GetAll_Result> spRezervare_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spRezervare_GetAll_Result>("spRezervare_GetAll");
        }
    
        public virtual ObjectResult<spRezervare_GetAllByClient_Result> spRezervare_GetAllByClient(Nullable<int> id_client)
        {
            var id_clientParameter = id_client.HasValue ?
                new ObjectParameter("id_client", id_client) :
                new ObjectParameter("id_client", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spRezervare_GetAllByClient_Result>("spRezervare_GetAllByClient", id_clientParameter);
        }
    
        public virtual int spRezervare_Insert(Nullable<int> id_client, Nullable<int> nr_camera, Nullable<int> nr_persoane, Nullable<System.DateTime> data_check_in, Nullable<System.DateTime> data_check_out, Nullable<System.DateTime> data_rezervare)
        {
            var id_clientParameter = id_client.HasValue ?
                new ObjectParameter("id_client", id_client) :
                new ObjectParameter("id_client", typeof(int));
    
            var nr_cameraParameter = nr_camera.HasValue ?
                new ObjectParameter("nr_camera", nr_camera) :
                new ObjectParameter("nr_camera", typeof(int));
    
            var nr_persoaneParameter = nr_persoane.HasValue ?
                new ObjectParameter("nr_persoane", nr_persoane) :
                new ObjectParameter("nr_persoane", typeof(int));
    
            var data_check_inParameter = data_check_in.HasValue ?
                new ObjectParameter("data_check_in", data_check_in) :
                new ObjectParameter("data_check_in", typeof(System.DateTime));
    
            var data_check_outParameter = data_check_out.HasValue ?
                new ObjectParameter("data_check_out", data_check_out) :
                new ObjectParameter("data_check_out", typeof(System.DateTime));
    
            var data_rezervareParameter = data_rezervare.HasValue ?
                new ObjectParameter("data_rezervare", data_rezervare) :
                new ObjectParameter("data_rezervare", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRezervare_Insert", id_clientParameter, nr_cameraParameter, nr_persoaneParameter, data_check_inParameter, data_check_outParameter, data_rezervareParameter);
        }
    
        public virtual ObjectResult<spServiciu_GetAll_Result> spServiciu_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spServiciu_GetAll_Result>("spServiciu_GetAll");
        }
    
        public virtual ObjectResult<spServiciu_GetById_Result> spServiciu_GetById(Nullable<int> id_serviciu)
        {
            var id_serviciuParameter = id_serviciu.HasValue ?
                new ObjectParameter("id_serviciu", id_serviciu) :
                new ObjectParameter("id_serviciu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spServiciu_GetById_Result>("spServiciu_GetById", id_serviciuParameter);
        }
    
        public virtual int spServiciu_Insert(Nullable<int> id_serviciu, string denumire, Nullable<int> pret)
        {
            var id_serviciuParameter = id_serviciu.HasValue ?
                new ObjectParameter("id_serviciu", id_serviciu) :
                new ObjectParameter("id_serviciu", typeof(int));
    
            var denumireParameter = denumire != null ?
                new ObjectParameter("denumire", denumire) :
                new ObjectParameter("denumire", typeof(string));
    
            var pretParameter = pret.HasValue ?
                new ObjectParameter("pret", pret) :
                new ObjectParameter("pret", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spServiciu_Insert", id_serviciuParameter, denumireParameter, pretParameter);
        }
    
        public virtual int spServiciu_rezervare_Insert(Nullable<int> id_client, string nr_camera, Nullable<int> id_serviciu)
        {
            var id_clientParameter = id_client.HasValue ?
                new ObjectParameter("id_client", id_client) :
                new ObjectParameter("id_client", typeof(int));
    
            var nr_cameraParameter = nr_camera != null ?
                new ObjectParameter("nr_camera", nr_camera) :
                new ObjectParameter("nr_camera", typeof(string));
    
            var id_serviciuParameter = id_serviciu.HasValue ?
                new ObjectParameter("id_serviciu", id_serviciu) :
                new ObjectParameter("id_serviciu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spServiciu_rezervare_Insert", id_clientParameter, nr_cameraParameter, id_serviciuParameter);
        }
    
        public virtual ObjectResult<string> spDotare_GetNameRaportRowCount(Nullable<int> nr_camera)
        {
            var nr_cameraParameter = nr_camera.HasValue ?
                new ObjectParameter("nr_camera", nr_camera) :
                new ObjectParameter("nr_camera", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("spDotare_GetNameRaportRowCount", nr_cameraParameter);
        }
    
        public virtual ObjectResult<spGetServiceByRez_Result> spGetServiceByRez(Nullable<int> nr_camera, Nullable<int> id_client)
        {
            var nr_cameraParameter = nr_camera.HasValue ?
                new ObjectParameter("nr_camera", nr_camera) :
                new ObjectParameter("nr_camera", typeof(int));
    
            var id_clientParameter = id_client.HasValue ?
                new ObjectParameter("id_client", id_client) :
                new ObjectParameter("id_client", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetServiceByRez_Result>("spGetServiceByRez", nr_cameraParameter, id_clientParameter);
        }
    
        public virtual ObjectResult<spRezervareRaportv2_Result> spRezervareRaportv2(Nullable<int> nr_camera, Nullable<int> id_client)
        {
            var nr_cameraParameter = nr_camera.HasValue ?
                new ObjectParameter("nr_camera", nr_camera) :
                new ObjectParameter("nr_camera", typeof(int));
    
            var id_clientParameter = id_client.HasValue ?
                new ObjectParameter("id_client", id_client) :
                new ObjectParameter("id_client", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spRezervareRaportv2_Result>("spRezervareRaportv2", nr_cameraParameter, id_clientParameter);
        }
    }
}
