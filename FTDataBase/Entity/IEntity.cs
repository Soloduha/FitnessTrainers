using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FTDataBase.Entity
{
    public interface IEntity
    {
        [Key]
        int Id { get; set; }
    }
}
