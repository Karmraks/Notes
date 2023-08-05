﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Application.Notes.Commands.UpdateNote;

namespace Notes.WebApi.Models
{
    public class UpdateNoteDto : IMapWith<UpdateNoteCommand>
    {
        public Guid Id { get; set; }
        public string Tiltle { get; set; }
        public string Details { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateNoteDto, UpdateNoteCommand>()
                .ForMember(noteCommand => noteCommand.Id,
                    opt => opt.MapFrom(noteDto => noteDto.Id))
                .ForMember(noteCommand => noteCommand.Title,
                    opt=> opt.MapFrom(noteDto => noteDto.Tiltle))
                .ForMember(noteCommand => noteCommand.Details,
                    opt=> opt.MapFrom(noteDto => noteDto.Details));
        }
    }   
}
