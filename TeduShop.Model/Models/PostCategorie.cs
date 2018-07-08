﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategorie 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(256)]   
        public string Alias { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        public int? ParentID { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }
        public bool? HomeFlag { set; get; }
        public virtual IEnumerable<Post> Post { set; get; }
    }
}