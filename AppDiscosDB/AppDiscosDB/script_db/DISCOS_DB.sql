SELECT Titulo, FechaLanzamiento, UrlImagenTapa, CantidadCanciones, T.Descripcion, E.Descripcion from DISCOS D, ESTILOS T, TIPOSEDICION E 
where D.IdEstilo = T.Id AND E.Id = D.IdTipoEdicion