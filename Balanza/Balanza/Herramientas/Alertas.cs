using Balanza.Forms;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balanza.Herramientas
{
    public static class Alertas
    {
        public static void ShowExito(string mensaje)
        {
            //FADE BAKGROUND
            Form backGround = new Form();

            backGround.StartPosition = FormStartPosition.Manual;
            backGround.Location = new Point(Form1.ActiveForm.Location.X, Form1.ActiveForm.Location.Y);
            backGround.Size = new Size(1128, 717);
            backGround.FormBorderStyle = FormBorderStyle.None;
            backGround.Opacity = .70d;
            backGround.BackColor = Color.Black;
            backGround.ShowInTaskbar = false;
            backGround.Show();

            NotificacionForm notificacion = new NotificacionForm(backGround);
            notificacion.SetFormato(mensaje);
            notificacion.BringToFront();
            notificacion.ShowDialog();

            backGround.Dispose();
        }

        public static void ShowError(string mensaje)
        {
            //FADE BAKGROUND
            Form backGround = new Form();

            backGround.StartPosition = FormStartPosition.Manual;
            backGround.Location = new Point(Form1.ActiveForm.Location.X, Form1.ActiveForm.Location.Y);
            backGround.Size = new Size(1128, 717);
            backGround.FormBorderStyle = FormBorderStyle.None;
            backGround.Opacity = .70d;
            backGround.BackColor = Color.Black;
            backGround.ShowInTaskbar = false;
            backGround.Show();

            AlertaForm alerta = new AlertaForm(backGround);
            alerta.SetFormato(mensaje);
            alerta.BringToFront();
            alerta.ShowDialog();

            backGround.Dispose();
        }

        public static void ShowAsignarCamion(camiones camion, proveedores proveedor)
        {
            //FADE BAKGROUND
            Form backGround = new Form();

            backGround.StartPosition = FormStartPosition.Manual;
            backGround.Location = new Point(Form1.ActiveForm.Location.X, Form1.ActiveForm.Location.Y);
            backGround.Size = new Size(1128, 717);
            backGround.FormBorderStyle = FormBorderStyle.None;
            backGround.Opacity = .70d;
            backGround.BackColor = Color.Black;
            backGround.ShowInTaskbar = false;
            backGround.Show();

            AlertaAsignarCamionForm alerta = new AlertaAsignarCamionForm(backGround, proveedor, camion);
            alerta.BringToFront();
            alerta.ShowDialog();

            backGround.Dispose();
        }

        public static void ShowAsignarCamion(camiones camion, clientes cliente)
        {
            //FADE BAKGROUND
            Form backGround = new Form();

            backGround.StartPosition = FormStartPosition.Manual;
            backGround.Location = new Point(Form1.ActiveForm.Location.X, Form1.ActiveForm.Location.Y);
            backGround.Size = new Size(1128, 717);
            backGround.FormBorderStyle = FormBorderStyle.None;
            backGround.Opacity = .70d;
            backGround.BackColor = Color.Black;
            backGround.ShowInTaskbar = false;
            backGround.Show();

            AlertaAsignarCamionForm alerta = new AlertaAsignarCamionForm(backGround, cliente, camion);
            alerta.BringToFront();
            alerta.ShowDialog();

            backGround.Dispose();
        }

        public static void ShowCrearCamion(string patente, proveedores proveedor)
        {
            //FADE BAKGROUND
            Form backGround = new Form();

            backGround.StartPosition = FormStartPosition.Manual;
            backGround.Location = new Point(Form1.ActiveForm.Location.X, Form1.ActiveForm.Location.Y);
            backGround.Size = new Size(1128, 717);
            backGround.FormBorderStyle = FormBorderStyle.None;
            backGround.Opacity = .70d;
            backGround.BackColor = Color.Black;
            backGround.ShowInTaskbar = false;
            backGround.Show();

            AlertaNuevoCamionForm alerta = new AlertaNuevoCamionForm(backGround, proveedor, patente);
            alerta.BringToFront();
            alerta.ShowDialog();

            backGround.Dispose();
        }

        public static void ShowCrearCamion(string patente, clientes cliente)
        {
            //FADE BAKGROUND
            Form backGround = new Form();

            backGround.StartPosition = FormStartPosition.Manual;
            backGround.Location = new Point(Form1.ActiveForm.Location.X, Form1.ActiveForm.Location.Y);
            backGround.Size = new Size(1128, 717);
            backGround.FormBorderStyle = FormBorderStyle.None;
            backGround.Opacity = .70d;
            backGround.BackColor = Color.Black;
            backGround.ShowInTaskbar = false;
            backGround.Show();

            AlertaNuevoCamionForm alerta = new AlertaNuevoCamionForm(backGround, cliente, patente);
            alerta.BringToFront();
            alerta.ShowDialog();

            backGround.Dispose();
        }

        public static void ShowObservaciones(registros_tarjetas registro, string obsPlanta, string obsWeb)
        {
            //FADE BAKGROUND
            Form backGround = new Form();

            backGround.StartPosition = FormStartPosition.Manual;
            backGround.Location = new Point(Form1.ActiveForm.Location.X, Form1.ActiveForm.Location.Y);
            backGround.Size = new Size(1128, 717);
            backGround.FormBorderStyle = FormBorderStyle.None;
            backGround.Opacity = .70d;
            backGround.BackColor = Color.Black;
            backGround.ShowInTaskbar = false;
            backGround.Show();

            AlertaObservaciones alerta = new AlertaObservaciones(backGround);
            alerta.SetFormato(registro, obsPlanta, obsWeb);
            alerta.BringToFront();
            alerta.ShowDialog();

            backGround.Dispose();
        }
    }
}
