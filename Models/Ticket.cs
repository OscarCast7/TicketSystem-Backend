namespace TicketApi.Models;

public class Ticket
{
    public int Id {get; set; }
    public string Title {get; set; } = string.Empty;
    public string Description {get; set; } = string.Empty;
    public string Status {get; set; } = "Pendiente"; //Pendiente, En Proceso, Resuelto, Cerrado
    public string Priority {get; set; } = "Media"; //Baja, Media, Alta, Crítica

    public int CreatedByUserId { get; set; }
    public User? CreatedByUser { get; set; }
    
    public int? AssignedToUserId { get; set; }
    public User? AssignedToUser { get; set; }
    
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}