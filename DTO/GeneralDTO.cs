using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GeneralDTO
    {
        public List<PostDTO> SliderPost { get; set; }
        public List<PostDTO> PopularPost { get; set; }  
        public List<PostDTO> MostViewedPost { get; set; }  
        public List<PostDTO> BreakingPost { get; set; }
        public PostDTO PostDetail { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; } //Esta propriedade foi acionada por causar erro!
        public string CommentContent { get; set; }  //Esta propriedade foi acionada por causar erro!
        public string Phone { get; set; }
        public string VehiclePlate { get; set; }
        public string VehicleBrand { get; set; }
        public string VehicleModel { get; set; }
        public string Year { get; set; }    
        public string ProblemDescription { get; set; }
        public string SearchText { get; set; }  
        public int PostID { get; set; }
        public List<PostDTO> CategoryPostList { get; set; }
        public string CategoryName { get; set; }
        public AddressDTO Address { get; set; }



    }
}