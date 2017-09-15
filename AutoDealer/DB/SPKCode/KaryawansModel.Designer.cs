﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace AutoDealer.DB.its_honda
{

    [Persistent(@"karyawans")]
    public partial class KaryawansModel : XPLiteObject
    {
        long fid;
        [Key(true)]
        public long id
        {
            get { return fid; }
            set { SetPropertyValue<long>("id", ref fid, value); }
        }
        string fnama_karyawan;
        [Size(255)]
        public string nama_karyawan
        {
            get { return fnama_karyawan; }
            set { SetPropertyValue<string>("nama_karyawan", ref fnama_karyawan, value); }
        }
        string falamat;
        [Size(255)]
        public string alamat
        {
            get { return falamat; }
            set { SetPropertyValue<string>("alamat", ref falamat, value); }
        }
        string ftanggal_masuk;
        [Size(255)]
        public string tanggal_masuk
        {
            get { return ftanggal_masuk; }
            set { SetPropertyValue<string>("tanggal_masuk", ref ftanggal_masuk, value); }
        }
        string ftanggal_resign;
        [Size(255)]
        public string tanggal_resign
        {
            get { return ftanggal_resign; }
            set { SetPropertyValue<string>("tanggal_resign", ref ftanggal_resign, value); }
        }
        string fketerangan_resign;
        [Size(255)]
        public string keterangan_resign
        {
            get { return fketerangan_resign; }
            set { SetPropertyValue<string>("keterangan_resign", ref fketerangan_resign, value); }
        }
        DateTime fcreatedAt;
        public DateTime createdAt
        {
            get { return fcreatedAt; }
            set { SetPropertyValue<DateTime>("createdAt", ref fcreatedAt, value); }
        }
        DateTime fupdatedAt;
        public DateTime updatedAt
        {
            get { return fupdatedAt; }
            set { SetPropertyValue<DateTime>("updatedAt", ref fupdatedAt, value); }
        }
        DateTime fdeletedAt;
        public DateTime deletedAt
        {
            get { return fdeletedAt; }
            set { SetPropertyValue<DateTime>("deletedAt", ref fdeletedAt, value); }
        }
        int fversion;
        public int version
        {
            get { return fversion; }
            set { SetPropertyValue<int>("version", ref fversion, value); }
        }
        DivisisModel fdivisiId;
        [Association(@"KaryawansModelReferencesDivisisModel")]
        public DivisisModel divisiId
        {
            get { return fdivisiId; }
            set { SetPropertyValue<DivisisModel>("divisiId", ref fdivisiId, value); }
        }
        JabatansModel fjabatanId;
        [Association(@"KaryawansModelReferencesJabatansModel")]
        public JabatansModel jabatanId
        {
            get { return fjabatanId; }
            set { SetPropertyValue<JabatansModel>("jabatanId", ref fjabatanId, value); }
        }
        BranchesModel fbranchId;
        [Association(@"KaryawansModelReferencesBranchesModel")]
        public BranchesModel branchId
        {
            get { return fbranchId; }
            set { SetPropertyValue<BranchesModel>("branchId", ref fbranchId, value); }
        }
        [Association(@"BranchmanagersModelReferencesKaryawansModel")]
        public XPCollection<BranchmanagersModel> BranchmanagersModelCollection { get { return GetCollection<BranchmanagersModel>("BranchmanagersModelCollection"); } }
        [Association(@"GeneralmanagersModelReferencesKaryawansModel")]
        public XPCollection<GeneralmanagersModel> GeneralmanagersModelCollection { get { return GetCollection<GeneralmanagersModel>("GeneralmanagersModelCollection"); } }
        [Association(@"OwnersModelReferencesKaryawansModel")]
        public XPCollection<OwnersModel> OwnersModelCollection { get { return GetCollection<OwnersModel>("OwnersModelCollection"); } }
        [Association(@"SalesheadsModelReferencesKaryawansModel")]
        public XPCollection<SalesheadsModel> SalesheadsModelCollection { get { return GetCollection<SalesheadsModel>("SalesheadsModelCollection"); } }
        [Association(@"UsersModelReferencesKaryawansModel")]
        public XPCollection<UsersModel> UsersModelCollection { get { return GetCollection<UsersModel>("UsersModelCollection"); } }
    }

}
