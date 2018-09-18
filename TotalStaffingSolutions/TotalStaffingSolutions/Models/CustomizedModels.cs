using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TotalStaffingSolutions.Models
{
    public class Empmast
    {
        public string Emcempmast { get; set; }
        public string Emcempid { get; set; }
        public string Emcstatus { get; set; }
        public string Emcfname { get; set; }
        public string Emcmname { get; set; }
        public string Emclname { get; set; }
        public string Emcaddr1 { get; set; }
        public string Emcaddr2 { get; set; }
        public string Emccity { get; set; }
        public string Emcstate { get; set; }
        public string Emczipcode { get; set; }
        public string Emccountry { get; set; }
        public string Emcssno { get; set; }
        public string Emcdeptcde { get; set; }
        public string Emcoffcde { get; set; }
        public string Emcloccde { get; set; }
        public string Emcworkcde { get; set; }
        public string Emcsm1cde { get; set; }
        public string Emcsm2cde { get; set; }
        public string Emcrankcde { get; set; }
        public string Emcprecall { get; set; }
        public string Emcschrecd { get; set; }
        public string Emccarcde { get; set; }
        public string Emcmarital { get; set; }
        public string Emcrace { get; set; }
        public string Emcsex { get; set; }
        public Nullable<System.DateTime> Emtbirth { get; set; }
        public Nullable<System.DateTime> Emthire { get; set; }
        public Nullable<System.DateTime> Emtrehire { get; set; }
        public Nullable<System.DateTime> Emtterm { get; set; }
        public string Emctermcde { get; set; }
        public string Emcnhmdben { get; set; }
        public string Emccorpcde { get; set; }
        public string Emcqmoccu { get; set; }
        public string Emcqmarea { get; set; }
        public string Emcssfname { get; set; }
        public string Emcssmname { get; set; }
        public string Emcsslname { get; set; }
        public string Emctino { get; set; }
        public string Emctiname { get; set; }
        public string Emcextrnid { get; set; }
        public string Emcemptype { get; set; }
        public string Emcpyfreq { get; set; }
        public string Emcpytype { get; set; }
        public decimal Emnsalamt { get; set; }
        public decimal Emnsblamt { get; set; }
        public decimal Emnsalhrs { get; set; }
        public string Emcsalcust { get; set; }
        public string Emcsalcomp { get; set; }
        public string Emcspyrule { get; set; }
        public string Emcsblrule { get; set; }
        public System.DateTime Emtsalppe { get; set; }
        public string Emcholpy { get; set; }
        public string Emmholexcl { get; set; }
        public string Emcovtrule { get; set; }
        public string Emcchkcde { get; set; }
        public System.DateTime Emt1stchk { get; set; }
        public System.DateTime Emtlstchk { get; set; }
        public decimal Emnacumhr1 { get; set; }
        public decimal Emnacumhr2 { get; set; }
        public string Emcddtype { get; set; }
        public string Emcddrout { get; set; }
        public string Emcddacct { get; set; }
        public string Emcddpren { get; set; }
        public decimal Emnddamt { get; set; }
        public string Emcddcalc { get; set; }
        public string Emcdd2type { get; set; }
        public string Emcdd2rout { get; set; }
        public string Emcdd2acct { get; set; }
        public string Emcdd2pren { get; set; }
        public System.DateTime Emtddnext { get; set; }
        public string Emcdeunion { get; set; }
        public string Emcwglnk1 { get; set; }
        public string Emcgenms1 { get; set; }
        public string Emcivrstat { get; set; }
        public string Emcemppin { get; set; }
        public string Emclucid { get; set; }
        public string Emcgenexp { get; set; }
        public string Emcoldkey { get; set; }
        public System.DateTime Emtlastexp { get; set; }
        public System.DateTime Emtlastimp { get; set; }
        public string Emcimpexp { get; set; }
        public string Emcmergeid { get; set; }
        public string Emcbrnchid { get; set; }
        public System.DateTime Emtadded { get; set; }
        public string Emcftstat { get; set; }
        public string Emcpolmast { get; set; }
        public string Emc1095err { get; set; }
        public string Emc1095cor { get; set; }
    }


    public class Cusmast
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cusmast()
        {
            this.Cusconts = new HashSet<Cuscont>();
        }

        public string Cuccusmast { get; set; }
        public string Cuccustid { get; set; }
        public string Cucrecmast { get; set; }
        public string Cucsitecde { get; set; }
        public string Cucname { get; set; }
        public string Cucaddr1 { get; set; }
        public string Cucaddr2 { get; set; }
        public string Cuccity { get; set; }
        public string Cucstate { get; set; }
        public string Cuczipcode { get; set; }
        public string Cuccountry { get; set; }
        public string Cucstatus { get; set; }
        public string Cucoffcde { get; set; }
        public string Cucsm1cde { get; set; }
        public string Cucsm2cde { get; set; }
        public string Cucloccde { get; set; }
        public string Cucbuscde { get; set; }
        public Nullable<System.DateTime> Cutadded { get; set; }
        public string Cucblable { get; set; }
        public string Cucstaxcde { get; set; }
        public string Cucschgcde { get; set; }
        public string Cucsttxcde { get; set; }
        public string Cuccttxcde { get; set; }
        public string Cucdeunion { get; set; }
        public string Cucwglnk1 { get; set; }
        public string Cucpono { get; set; }
        public string Cucrelno { get; set; }
        public string Cucprojno { get; set; }
        public string Cucgenexp { get; set; }
        public string Cucschrecd { get; set; }
        public string Cucdstadj { get; set; }
        public string Cucoldkey { get; set; }
        public System.DateTime Cutlastexp { get; set; }
        public System.DateTime Cutlastimp { get; set; }
        public string Cucimpexp { get; set; }
        public string Cucmergeid { get; set; }
        public string Cucbrnchid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuscont> Cusconts { get; set; }
    }


    public class Cuscont
    {
        public string Ccccuscont { get; set; }
        public string Ccccusmast { get; set; }
        public string Ccccontcde { get; set; }
        public string Ccccatcde { get; set; }
        public string Ccccontact { get; set; }
        public string Ccccontmsc { get; set; }
        public string Cccphone1 { get; set; }
        public string Cccphone2 { get; set; }
        public string Cccphone3 { get; set; }
        public string Cccemail { get; set; }
        public string Cccsalcde { get; set; }
        public string Cccfname { get; set; }
        public string Cccmname { get; set; }
        public string Ccclname { get; set; }
        public string Cccemlbody { get; set; }
        public string Ccmnotes { get; set; }

        public virtual Cusmast Cusmast { get; set; }
    }

    public class Customer_contact
    {
        public string Ccccuscont { get; set; }
        public string Ccccusmast { get; set; }
        public string Ccccontcde { get; set; }
        public string Ccccatcde { get; set; }
        public string Ccccontact { get; set; }
        public string Ccccontmsc { get; set; }
        public string Cccphone1 { get; set; }
        public string Cccphone2 { get; set; }
        public string Cccphone3 { get; set; }
        public string Cccemail { get; set; }
        public string Cccsalcde { get; set; }
        public string Cccfname { get; set; }
        public string Cccmname { get; set; }
        public string Ccclname { get; set; }
        public string Cccemlbody { get; set; }
        public string Ccmnotes { get; set; }
        public string Customer_id { get; set; }
    }
}