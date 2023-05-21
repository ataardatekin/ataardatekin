using ECommerce.Entity.Enum;
using ECommerce.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.Base
{
    public abstract class BaseEntity : IEntity<Guid>
    {
        public BaseEntity()
        {
            IsActive = true;
            Status = Status.Created;
            CreatedDate = DateTime.Now;
            MasterId = Guid.NewGuid();

        }


        public int Id { get; set; }
        //Eğer primary key property adı Id yerine farklı bir isim ile adlandırılmışsa o halde ilgili property'nin üzerinde [key] tanımlanmalıdır.
        public Guid MasterId { get; set; }

        //Created
        public DateTime CreatedDate { get; set; }
        [StringLength(255)]
        public string? CreatedComputerName { get; set; }
        [StringLength(255)]
        public string? CreatedAdminUsername { get; set; }
        [StringLength(255)]
        public string? CreatedIpAddress { get; set; }

        //Updated
        public DateTime UpdatedDate { get; set; }
        [StringLength(255)]
        public string? UpdatedComputerName { get; set; }
        [StringLength(255)]
        public string? UpdatedAdminUsername { get; set; }
        [StringLength(255)]
        public string? UpdatedIpAddress { get; set; }
        public bool IsActive { get; set; }
        public Status Status { get; set; }
    }
}
