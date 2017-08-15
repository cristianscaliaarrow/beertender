using System.Collections.Generic;

public class User{
	public string mail;
	public string dni;
	public string nombre;
	public string apellido;
	public Rol rol;
	public string telefono;
	public int idPM;
	public static Rol currentRol = Rol.STAFF;
}


public class Local{
	public string nombre;
	public int idPM;
	public int objetivoVolumen;
	public int objetivoDisponibilidad;
}

public class Registros{
	public string fecha;
	public string email;
	public string puntosMotivo;
	public int cant;
	public int puntos;
}

public class Premios{
	public string nombre;
	public string descripcion;
	public UnityEngine.Sprite imagen;
	public int puntos;
	public int catalogoId;
	public int sku;
}

public class ListMessages{
    public List<Message> messages = new List<Message>();
}

[System.Serializable]
public class Message
{
    public int id;
    public string message;
    public bool readed;

    public Message()
    {

    }

    public Message(string message, bool readed,int id)
    {
        this.id = id;
        this.message = message;
        this.readed = readed;
    }
}

public enum Rol{
	STAFF,MANAGER,OWNER
}
