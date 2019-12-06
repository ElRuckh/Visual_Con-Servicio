using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service_Music
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService2" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
         void Guardar(string NC, string NA, string Colb, string Gene, string Disqu, string FC);
        [OperationContract]
        bool Borrar(int idc);
        [OperationContract]
        bool editar(string NC, string NA, string Colb, string Gene ,string Disqu, string FC);
        [OperationContract]
        bool verificar(string art, string contra);
        [OperationContract]
        bool Regi_guar(string art, string pas, string corr);
        [OperationContract]
        string[] buscar(string nom);

    }
}
