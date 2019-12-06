USE Musica
CREATE TABLE Usuarios(
  IDNum_Usurio bigint NOT NULL IDENTITY (1,1) PRIMARY KEY,
  
  Artis_Nom nvarchar(50) NOT NULL ,
  
  Pass nvarchar(50)NOT NULL,
  
  Correo_oficial nvarchar(50)NOT NULL,
  
  
  
)
