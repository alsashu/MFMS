using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFMS.Domain
{
    [Table("mfms_client_subscription_details")]
    public class ClientSubscriptionDetail
    {
        [Key, Required]
        public long Id { get; set; }
        public long ClientId { get; set; }//FK in Client
        public int SubscriptionId { get; set; }
        public int PendingPoints { get; set; }
        public DateTime SubscribedDate { get; set; }
        public DateTime ValidityEndDate { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime ModifiedDate { get; set; }
    }
}
