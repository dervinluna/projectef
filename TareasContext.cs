using Microsoft.EntityFrameworkCore;
using projectoef.Models;

namespace projectoef;

public class TareasContext: DbContext
{
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Tarea> Tareas { get; set; }
    public TareasContext(DbContextOptions<TareasContext> options) :base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
         List<Categoria> categoriasInit = new List<Categoria>();
         categoriasInit.Add(new Categoria { CategoriaId =  Guid.Parse("155a6ffb-bb0c-4956-abb1-4e817000e529"), Nombre = "Actividades pendientes", Peso = 20});
         categoriasInit.Add(new Categoria { CategoriaId =  Guid.Parse("155a6ffb-bb0c-4956-abb1-4e817000e530"), Nombre = "Actividades personales", Peso = 50});
         categoriasInit.Add(new Categoria { CategoriaId =  Guid.Parse("155a6ffb-bb0c-4956-abb1-4e817000e531"), Nombre = "Actividades laborales", Peso = 30});

        modelBuilder.Entity<Categoria>(categoria =>
        {
            categoria.ToTable("Categoria");
            categoria.HasKey(p => p.CategoriaId);
            categoria.Property(p => p.Nombre).IsRequired().HasMaxLength(150);
            categoria.Property(p => p.Descripcion).IsRequired(false);
            categoria.Property(p => p.Peso);
            categoria.HasData(categoriasInit);

        });

        List<Tarea> tareasInit = new List<Tarea>();
        tareasInit.Add(new Tarea { TareaId = Guid.Parse("155a6ffb-bb0c-4956-abb1-4e817000e531"), CategoriaId =  Guid.Parse("155a6ffb-bb0c-4956-abb1-4e817000e529"), PrioridadTarea = Prioridad.Media,  Titulo = "Pago de servicios publicos", FechaCreacion = DateTime.Now });
        tareasInit.Add(new Tarea { TareaId = Guid.Parse("155a6ffb-bb0c-4956-abb1-4e817000e532"), CategoriaId =  Guid.Parse("155a6ffb-bb0c-4956-abb1-4e817000e530"), PrioridadTarea = Prioridad.Baja,  Titulo = "Terminar de ver pelicula en netfix", FechaCreacion = DateTime.Now });
        tareasInit.Add(new Tarea { TareaId = Guid.Parse("155a6ffb-bb0c-4956-abb1-4e817000e533"), CategoriaId =  Guid.Parse("155a6ffb-bb0c-4956-abb1-4e817000e531"), PrioridadTarea = Prioridad.Alta,  Titulo = "Terminar el reporte mensual de ventas", FechaCreacion = DateTime.Now });


        modelBuilder.Entity<Tarea>(tarea => 
        {
            tarea.ToTable("Tarea");
            tarea.HasKey(p => p.TareaId);
            tarea.HasOne(p => p.Categoria).WithMany(p=> p.Tareas).HasForeignKey(p => p.CategoriaId);
            tarea.Property(p => p.Titulo).IsRequired().HasMaxLength(200);
            tarea.Property(p => p.Descripcion).IsRequired(false);
            tarea.Property(p => p.PrioridadTarea);
            tarea.Property(p => p.FechaCreacion);
            tarea.Ignore(p => p.Resumen);
            tarea.HasData(tareasInit);
        });
    }
    
}