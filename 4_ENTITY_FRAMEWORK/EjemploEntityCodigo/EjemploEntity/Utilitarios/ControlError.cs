namespace EjemploEntity.Utilitarios
{
    public class ControlError
    {
        public void LogErrorMetodos(string clase, string metodo, string error) 
        {
			var ruta = string.Empty;
			var archivo = string.Empty;
			DateTime Fecha = DateTime.Now;
			try
			{
				ruta = "C:\\Users\\usuario\\Documents\\Drive\\FromAlienware\\source\\VMTDEV_BOOTCAMP_2024\\4_ENTITY_FRAMEWORK\\LogsEjemploEntityCodigo";
				archivo = $"Log_{Fecha.ToString("dd-M-yyyy")}";

				if (!Directory.Exists(ruta))
				{
					Directory.CreateDirectory(ruta);
				}

				StreamWriter writ = new StreamWriter($"{ruta}\\{archivo}");
				writ.WriteLine($"Se presento una novedad en la clase: {clase}, en el metodo: {metodo}, con el siguiente error: {error}");
				writ.Close();

            }
			catch (Exception ex)
			{

				throw;
			}
        }

    }
}
