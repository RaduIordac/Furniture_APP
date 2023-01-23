using Application.DTOs;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Parts.Delete
{
    public class DeletePartCommand : IRequest
    {
        public int Id { get; set; }

    }
}
