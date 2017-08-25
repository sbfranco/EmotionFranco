using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace emotionFranco.Web.Models
{
    public class EmoPicture
    {
        public int Id { get; set; }
        [Display(Name ="Nombre")]
        public string Name { get; set; }
        public string Path { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage = "La ruta supera el tamaño establecido")]
        public virtual ObservableCollection<EmoFace> Faces { get; set; }
    }
}