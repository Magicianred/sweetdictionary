using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
   public class WriterValidation : AbstractValidator<Writer>
    {
        public WriterValidation()
        {
            RuleFor(x => x.WriterFirstName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");
            RuleFor(x => x.WriterLastName).NotEmpty().WithMessage("Yazar Soyadını boş geçemezsiniz.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda alanını boş geçemezsiniz.");
            RuleFor(x => x.WriterFirstName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın");
            RuleFor(x => x.WriterLastName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.WriterFirstName).MaximumLength(50).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayın");
            RuleFor(x => x.WriterLastName).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayın");
            RuleFor(x => x.WriterAbout).MaximumLength(300).WithMessage("Lütfen 300 karakterden az değer girişi yapın.");
        }
        }
    }

