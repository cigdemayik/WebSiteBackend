using System;
using System.Collections.Generic;
using System.Text;

namespace WebSiteBackend.Business.Dtos.AddressDtos
{
    public class AddressUpdateDto
    {
        public int Id { get; set; }
        public int Language { get; set; }
        public string Content { get; set; }
    }
}
