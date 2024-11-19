using Microsoft.EntityFrameworkCore;
namespace Persistencia.Data{
    using Microsoft.EntityFrameworkCore;
    using Persistencia.DTOS;

    public class ApplicationDbContext : DbContext
{
    public DbSet<Evento> Eventos { get; set; }
    public DbSet<Instalacion> Instalaciones { get; set; }
    public DbSet<Notificacion> Notificaciones { get; set; }
    public DbSet<Pago> Pagos { get; set; }
    public DbSet<ProgramaDep> ProgramasDep { get; set; }
    public DbSet<Reserva> Reservas { get; set; }
    public DbSet<Sede> Sedes { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Evento
        modelBuilder.Entity<Evento>()
            .HasKey(e => e.EventoId);

        modelBuilder.Entity<Evento>()
            .Property(e => e.Nombre)
            .HasMaxLength(255)
            .IsRequired();

        modelBuilder.Entity<Evento>()
            .Property(e => e.Descripcion)
            .HasMaxLength(500);

        modelBuilder.Entity<Evento>()
            .Property(e => e.Fecha_Inicio)
            .IsRequired();

        modelBuilder.Entity<Evento>()
            .Property(e => e.Fecha_Fin)
            .IsRequired();

        modelBuilder.Entity<Evento>()
            .Property(e => e.capcidad)
            .IsRequired();

        modelBuilder.Entity<Evento>()
            .Property(e => e.Tarifa_Afiliado)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<Evento>()
            .Property(e => e.Tarifa_No_Afiliado)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<Evento>()
            .Property(e => e.Estado)
            .IsRequired();

        // Instalacion
        modelBuilder.Entity<Instalacion>()
            .HasKey(i => i.InstalacionId);

        modelBuilder.Entity<Instalacion>()
            .Property(i => i.Nombre)
            .HasMaxLength(255)
            .IsRequired();

        modelBuilder.Entity<Instalacion>()
            .Property(i => i.Tipo)
            .HasMaxLength(100)
            .IsRequired();

        modelBuilder.Entity<Instalacion>()
            .Property(i => i.Capacidad)
            .IsRequired();

        modelBuilder.Entity<Instalacion>()
            .Property(i => i.Descripcion)
            .HasMaxLength(500);

        modelBuilder.Entity<Instalacion>()
            .Property(i => i.Estado)
            .IsRequired();

        modelBuilder.Entity<Instalacion>()
            .Property(i => i.Disponibilidad)
            .IsRequired();

        // Notificacion
        modelBuilder.Entity<Notificacion>()
            .HasKey(n => n.NotificacionId);

        modelBuilder.Entity<Notificacion>()
            .Property(n => n.Titulo)
            .HasMaxLength(255)
            .IsRequired();

        modelBuilder.Entity<Notificacion>()
            .Property(n => n.Leido)
            .IsRequired();

        modelBuilder.Entity<Notificacion>()
            .Property(n => n.Fecha_Envio)
            .HasMaxLength(100);

        // Pago
        modelBuilder.Entity<Pago>()
            .HasKey(p => p.PagoId);

        modelBuilder.Entity<Pago>()
            .Property(p => p.Monto)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<Pago>()
            .Property(p => p.Fecha_Pago)
            .HasMaxLength(100);

        modelBuilder.Entity<Pago>()
            .Property(p => p.Metodo_Pago)
            .IsRequired();

        modelBuilder.Entity<Pago>()
            .Property(p => p.Estado_Pago)
            .IsRequired();

        // ProgramaDep
        modelBuilder.Entity<ProgramaDep>()
            .HasKey(p => p.ProgramaId);

        modelBuilder.Entity<ProgramaDep>()
            .Property(p => p.Nombre)
            .HasMaxLength(255)
            .IsRequired();

        modelBuilder.Entity<ProgramaDep>()
            .Property(p => p.Descripcion)
            .HasMaxLength(500);

        modelBuilder.Entity<ProgramaDep>()
            .Property(p => p.Tipo_Actividad)
            .HasMaxLength(100);

        modelBuilder.Entity<ProgramaDep>()
            .Property(p => p.Cupo)
            .IsRequired();

        modelBuilder.Entity<ProgramaDep>()
            .Property(p => p.Fecha_Inicio)
            .HasMaxLength(100);

        modelBuilder.Entity<ProgramaDep>()
            .Property(p => p.Fecha_Fin)
            .HasMaxLength(100);

        modelBuilder.Entity<ProgramaDep>()
            .Property(p => p.Tarifa_Afiliado)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<ProgramaDep>()
            .Property(p => p.Tarifa_No_Afiliado)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<ProgramaDep>()
            .Property(p => p.Estado)
            .IsRequired();

        // Reserva
        modelBuilder.Entity<Reserva>()
            .HasKey(r => r.ReservaId);

        modelBuilder.Entity<Reserva>()
            .Property(r => r.Fecha_Reserva)
            .HasMaxLength(100);

        modelBuilder.Entity<Reserva>()
            .Property(r => r.Hora_Inicio)
            .HasMaxLength(50);

        modelBuilder.Entity<Reserva>()
            .Property(r => r.Hora_Fin)
            .HasMaxLength(50);

        modelBuilder.Entity<Reserva>()
            .Property(r => r.Tarifa)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<Reserva>()
            .Property(r => r.Estado)
            .IsRequired();

        modelBuilder.Entity<Reserva>()
            .Property(r => r.Creacion)
            .HasMaxLength(100);

        // Sede
        modelBuilder.Entity<Sede>()
            .HasKey(s => s.SedeId);

        modelBuilder.Entity<Sede>()
            .Property(s => s.Nombre)
            .HasMaxLength(255)
            .IsRequired();

        modelBuilder.Entity<Sede>()
            .Property(s => s.Direccion)
            .HasMaxLength(500);

        modelBuilder.Entity<Sede>()
            .Property(s => s.Telefono)
            .HasMaxLength(50);

        modelBuilder.Entity<Sede>()
            .Property(s => s.Email)
            .HasMaxLength(255);

        modelBuilder.Entity<Sede>()
            .Property(s => s.Horario)
            .HasMaxLength(100);

        modelBuilder.Entity<Sede>()
            .Property(s => s.Estado)
            .IsRequired();

        modelBuilder.Entity<Sede>()
            .Property(s => s.Fecha_Creacion)
            .HasMaxLength(100);

        // Usuario
        modelBuilder.Entity<Usuario>()
            .HasKey(u => u.UsuarioId);

        modelBuilder.Entity<Usuario>()
            .Property(u => u.Tipo_Documento)
            .HasMaxLength(50);

        modelBuilder.Entity<Usuario>()
            .Property(u => u.Nombre)
            .HasMaxLength(255)
            .IsRequired();

        modelBuilder.Entity<Usuario>()
            .Property(u => u.Apellido)
            .HasMaxLength(255)
            .IsRequired();

        modelBuilder.Entity<Usuario>()
            .Property(u => u.Email)
            .HasMaxLength(255)
            .IsRequired();

        modelBuilder.Entity<Usuario>()
            .Property(u => u.Telefono)
            .HasMaxLength(50);

        modelBuilder.Entity<Usuario>()
            .Property(u => u.Password)
            .HasMaxLength(255);

        modelBuilder.Entity<Usuario>()
            .Property(u => u.Tipo_Usuario)
            .IsRequired();

        modelBuilder.Entity<Usuario>()
            .Property(u => u.Fecha_Registro)
            .HasMaxLength(100);

        modelBuilder.Entity<Usuario>()
            .Property(u => u.Estado)
            .IsRequired();

        base.OnModelCreating(modelBuilder);
    }
}

}