using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Notes.Application.Notes.Commands.DeleteCommand;

namespace Notes.Application.Notes.Commands.DeleteNote
{
    public class DeleteCommandValidator : AbstractValidator<DeleteNoteCommand>
    {
        public DeleteCommandValidator()
        {
            RuleFor(deleteNoteCommand =>
                deleteNoteCommand.UserId).NotEqual(Guid.Empty);
            RuleFor(deleteNoteCommand =>
                deleteNoteCommand.Id).NotEqual(Guid.Empty);
        }
    }
}
