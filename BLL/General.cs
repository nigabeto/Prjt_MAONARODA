using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class General
    {
        public static class ProcessType
        {
            public static int Login = 1;
            public static int AddressAdd = 2;
            public static int AddressUpdate = 3;
            public static int AddressDelete = 4;
            public static int CategoryAdd = 5;
            public static int CategoryUpdate = 6;
            public static int CategoryDelete = 7;
            public static int OrdemAdd = 8;
            public static int OrdemUpdate = 9;
            public static int OrdemDelete = 10;
            public static int PartsAdd = 11;
            public static int PartsUpdate = 12;
            public static int PartsDelete = 13;
            public static int PrestadorAdd = 14;
            public static int PrestadorUpdate = 15;
            public static int PrestadorDelete = 16;
            public static int RevendedorAdd = 17;
            public static int RevendedorUpdate = 18;
            public static int RevendedorDelete = 19;
            public static int ServicoAdd = 20;
            public static int ServicoUpdate = 21;
            public static int ServicoDelete = 22;
            public static int UserAdd = 23;
            public static int UserUpdate = 24;
            public static int UserDelete = 25;
            public static int PostAdd = 26;
            public static int PostUpdate = 27;
            public static int PostDelete = 28;
            public static int ImageAdd = 29;
            public static int ImageUpdate = 30;
            public static int ImageDelete = 31;
            public static int TagAdd = 32;
            public static int TagUpdate = 33;
            public static int TagDelete = 34;
            public static int CommentApprove = 35;
            public static int CommentDelete = 36;
            public static int ContactRead = 37;
            public static int ContactDelete = 38;
        }

        public static class TableName
        {
            public static string Login = "Login";
            public static string Address = "Address";
            public static string Category = "Category";
            public static string Ordem = "Ordem";
            public static string Parts = "Parts";
            public static string Prestador = "Prestador";
            public static string Revendedor = "Revendedor";
            public static string Servico = "Servico";
            public static string User = "User";
            public static string Post = "Post";
            public static string Image = "Image";
            public static string Tag = "Tag";
            public static string Comment = "Comment";
            public static string Contact = "Contact";
        }

        public static class Messages
        {
            public static int AddSuccess = 1;
            public static int EmptyArea = 2;
            public static int UpdateSuccess = 3;
            public static int ImageMissing = 4;
            public static int ExtensionError = 5;
            public static int GeneralError = 6;
        }
    }
}