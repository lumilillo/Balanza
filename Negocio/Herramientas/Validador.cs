using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Negocio.Herramientas
{
    public class Validador
    {
        #region Privadas

        private ValidationContext context;
        private List<ValidationResult> result;
        private bool valid;
        private string message;

        #endregion

        public Validador(object instance)
        {
            context = new ValidationContext(instance);
            result = new List<ValidationResult>();
            valid = Validator.TryValidateObject(instance, context, result, true);
        }

        public bool Validar()
        {
            if (valid == false)
            {
                foreach (ValidationResult item in result)
                {
                    message += item.ErrorMessage + ".\n";
                }
            }
            return valid;
        }
        public string MensajeError()
        {
            return message;
        }
    }
}
