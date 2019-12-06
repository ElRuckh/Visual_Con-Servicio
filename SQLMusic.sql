

USE Musica
CREATE TABLE BibliotecaM(
  IDArtista bigint NOT NULL IDENTITY (1,1) PRIMARY KEY,
  
  Nombre_Cancion nvarchar(50) NOT NULL ,
  
  Nombre_Album nvarchar(50)NOT NULL,
  
  Colaboradores nvarchar(50)NOT NULL,
  
  Genero nvarchar(50)NOT NULL,
  
  Disquera nvarchar(50)NOT NULL,
  
  Fecha_Creacion nvarchar(50)NOT NULL,

  
)
