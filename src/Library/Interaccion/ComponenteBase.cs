namespace Library
{
/// <summary>
/// La clase ComponenteBase sera la encargada de setear un mediador que luego será utilizado por el generador de perfil, 
/// para generar un perfil de usuario.
/// Buscamos bajar el acoplamiento creando ComponenteBase para eviar la dependencia directa del GeneradorPerfil con Mediador.
/// </summary>
    public class ComponenteBase
    {
        protected IMediador mediador;

        public ComponenteBase(IMediador mediador = null)
        {
            this.mediador = mediador;
        }

        public void SetMediador(IMediador mediador)
        {
            this.mediador = mediador;
        }
    }
    }
