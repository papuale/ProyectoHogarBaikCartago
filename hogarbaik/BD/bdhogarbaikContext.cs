using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace hogarbaik.BD
{
    public partial class bdhogarbaikContext : DbContext
    {
        public bdhogarbaikContext()
        {
        }

        public bdhogarbaikContext(DbContextOptions<bdhogarbaikContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actividad> Actividads { get; set; }
        public virtual DbSet<Bitacora> Bitacoras { get; set; }
        public virtual DbSet<ControlNinoEducativo> ControlNinoEducativos { get; set; }
        public virtual DbSet<ControlNinoMedico> ControlNinoMedicos { get; set; }
        public virtual DbSet<DetalleProyecto> DetalleProyectos { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<InformacionNino> InformacionNinos { get; set; }
        public virtual DbSet<InventarioAlimentacion> InventarioAlimentacions { get; set; }
        public virtual DbSet<InventarioInmueble> InventarioInmuebles { get; set; }
        public virtual DbSet<InventarioLimpieza> InventarioLimpiezas { get; set; }
        public virtual DbSet<InventarioMueble> InventarioMuebles { get; set; }
        public virtual DbSet<Proyecto> Proyectos { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Socio> Socios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=bdhogarbaik;username=root;password=123", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.5.10-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            modelBuilder.Entity<Actividad>(entity =>
            {
                entity.HasKey(e => e.PkCodigoActividad)
                    .HasName("PRIMARY");

                entity.ToTable("actividad");

                entity.Property(e => e.PkCodigoActividad)
                    .HasColumnType("int(11)")
                    .HasColumnName("pkCodigoActividad");

                entity.Property(e => e.DescripcionEvento)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.FechaEvento).HasColumnType("datetime");

                entity.Property(e => e.HoraEvento)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ImagenEvento)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LugarEvento)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NombreEvento)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoEvento).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Bitacora>(entity =>
            {
                entity.HasKey(e => e.PkCodigoBitacora)
                    .HasName("PRIMARY");

                entity.ToTable("bitacora");

                entity.HasIndex(e => e.IdCedulaEmpleado, "IdCedulaEmpleado");

                entity.HasIndex(e => e.IdCedulaNino, "IdCedulaNino");

                entity.HasIndex(e => e.IdCedulaSocio, "IdCedulaSocio");

                entity.HasIndex(e => e.IdCodigoAlimentacion, "IdCodigoAlimentacion");

                entity.HasIndex(e => e.IdCodigoInmueble, "IdCodigoInmueble");

                entity.HasIndex(e => e.IdCodigoLimpieza, "IdCodigoLimpieza");

                entity.HasIndex(e => e.IdCodigoMueble, "IdCodigoMueble");

                entity.HasIndex(e => e.IdCodigoProyecto, "IdCodigoProyecto");

                entity.Property(e => e.PkCodigoBitacora)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("pkCodigoBitacora");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaMovimiento).HasColumnType("datetime");

                entity.Property(e => e.IdCedulaEmpleado).HasColumnType("int(11)");

                entity.Property(e => e.IdCedulaNino).HasColumnType("int(11)");

                entity.Property(e => e.IdCedulaSocio).HasColumnType("int(11)");

                entity.Property(e => e.IdCodigoAlimentacion).HasColumnType("int(11)");

                entity.Property(e => e.IdCodigoInmueble).HasColumnType("int(11)");

                entity.Property(e => e.IdCodigoLimpieza).HasColumnType("int(11)");

                entity.Property(e => e.IdCodigoMueble).HasColumnType("int(11)");

                entity.Property(e => e.IdCodigoProyecto).HasColumnType("int(11)");

                entity.Property(e => e.Movimiento)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.IdCedulaEmpleadoNavigation)
                    .WithMany(p => p.Bitacoras)
                    .HasForeignKey(d => d.IdCedulaEmpleado)
                    .HasConstraintName("bitacora_ibfk_3");

                entity.HasOne(d => d.IdCedulaNinoNavigation)
                    .WithMany(p => p.Bitacoras)
                    .HasForeignKey(d => d.IdCedulaNino)
                    .HasConstraintName("bitacora_ibfk_1");

                entity.HasOne(d => d.IdCedulaSocioNavigation)
                    .WithMany(p => p.Bitacoras)
                    .HasForeignKey(d => d.IdCedulaSocio)
                    .HasConstraintName("bitacora_ibfk_8");

                entity.HasOne(d => d.IdCodigoAlimentacionNavigation)
                    .WithMany(p => p.Bitacoras)
                    .HasForeignKey(d => d.IdCodigoAlimentacion)
                    .HasConstraintName("bitacora_ibfk_5");

                entity.HasOne(d => d.IdCodigoInmuebleNavigation)
                    .WithMany(p => p.Bitacoras)
                    .HasForeignKey(d => d.IdCodigoInmueble)
                    .HasConstraintName("bitacora_ibfk_6");

                entity.HasOne(d => d.IdCodigoLimpiezaNavigation)
                    .WithMany(p => p.Bitacoras)
                    .HasForeignKey(d => d.IdCodigoLimpieza)
                    .HasConstraintName("bitacora_ibfk_4");

                entity.HasOne(d => d.IdCodigoMuebleNavigation)
                    .WithMany(p => p.Bitacoras)
                    .HasForeignKey(d => d.IdCodigoMueble)
                    .HasConstraintName("bitacora_ibfk_7");

                entity.HasOne(d => d.IdCodigoProyectoNavigation)
                    .WithMany(p => p.Bitacoras)
                    .HasForeignKey(d => d.IdCodigoProyecto)
                    .HasConstraintName("bitacora_ibfk_2");
            });

            modelBuilder.Entity<ControlNinoEducativo>(entity =>
            {
                entity.HasKey(e => e.PkCodigoEducativo)
                    .HasName("PRIMARY");

                entity.ToTable("control_nino_educativo");

                entity.Property(e => e.PkCodigoEducativo)
                    .HasColumnType("int(11)")
                    .HasColumnName("pkCodigoEducativo");

                entity.Property(e => e.ArchivoEducativo).HasMaxLength(200);

                entity.Property(e => e.CentroEducativo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Discapacidad)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FormaComunicacion)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.GradoAcademico)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Lateralidad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ProcesoEducativo)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ControlNinoMedico>(entity =>
            {
                entity.HasKey(e => e.PkCodigoMedico)
                    .HasName("PRIMARY");

                entity.ToTable("control_nino_medico");

                entity.Property(e => e.PkCodigoMedico)
                    .HasColumnType("int(11)")
                    .HasColumnName("pkCodigoMedico");

                entity.Property(e => e.ArchivoCarnetCitas).HasMaxLength(200);

                entity.Property(e => e.ArchivoCarnetVacunas).HasMaxLength(200);

                entity.Property(e => e.ArchivoEvolucion).HasMaxLength(200);

                entity.Property(e => e.Condicion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DescripcionCondicion)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Discapacidad)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Enfermedad)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Indicacion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Medicamento)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DetalleProyecto>(entity =>
            {
                entity.HasKey(e => e.PkDetalleProyecto)
                    .HasName("PRIMARY");

                entity.ToTable("detalle_proyecto");

                entity.Property(e => e.PkDetalleProyecto)
                    .HasColumnType("int(11)")
                    .HasColumnName("pkDetalleProyecto");

                entity.Property(e => e.DuracionProyecto)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaFinalizacion).HasColumnType("datetime");

                entity.Property(e => e.Material)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ServicioExterno)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.PkCedula)
                    .HasName("PRIMARY");

                entity.ToTable("empleado");

                entity.HasIndex(e => e.IdCodigoActividad, "IdCodigoActividad");

                entity.HasIndex(e => e.IdCodigoRol, "IdCodigoRol");

                entity.Property(e => e.PkCedula)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("pkCedula");

                entity.Property(e => e.Cargo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Contrasena).HasMaxLength(50);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.IdCodigoActividad).HasColumnType("int(11)");

                entity.Property(e => e.IdCodigoRol).HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NombreUsuario).HasMaxLength(50);

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Provincia)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SegundoApellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono).HasColumnType("int(11)");

                entity.HasOne(d => d.IdCodigoActividadNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdCodigoActividad)
                    .HasConstraintName("empleado_ibfk_1");

                entity.HasOne(d => d.IdCodigoRolNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdCodigoRol)
                    .HasConstraintName("empleado_ibfk_2");
            });

            modelBuilder.Entity<InformacionNino>(entity =>
            {
                entity.HasKey(e => e.PkCedula)
                    .HasName("PRIMARY");

                entity.ToTable("informacion_nino");

                entity.HasIndex(e => e.IdCodigoEducativo, "IdCodigoEducativo");

                entity.HasIndex(e => e.IdCodigoMedico, "IdCodigoMedico");

                entity.Property(e => e.PkCedula)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("pkCedula");

                entity.Property(e => e.ArchivoConstancia).HasMaxLength(200);

                entity.Property(e => e.ArchivoEgreso).HasMaxLength(200);

                entity.Property(e => e.ArchivoIngreso).HasMaxLength(200);

                entity.Property(e => e.CedulaEncargado).HasColumnType("int(11)");

                entity.Property(e => e.CedulaEncargadoEgreso).HasColumnType("int(11)");

                entity.Property(e => e.ContactoEgreso)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CorreoOficina)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DestinoEgreso)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DetalleEgreso)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Edad).HasColumnType("int(11)");

                entity.Property(e => e.EncargadoEgreso)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EncargadoIngreso)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaEgreso).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.IdCodigoEducativo).HasColumnType("int(11)");

                entity.Property(e => e.IdCodigoMedico).HasColumnType("int(11)");

                entity.Property(e => e.MotivoIngreso)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SegundoApellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoOficina).HasColumnType("int(11)");

                entity.Property(e => e.UbicacionOficina)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdCodigoEducativoNavigation)
                    .WithMany(p => p.InformacionNinos)
                    .HasForeignKey(d => d.IdCodigoEducativo)
                    .HasConstraintName("informacion_nino_ibfk_1");

                entity.HasOne(d => d.IdCodigoMedicoNavigation)
                    .WithMany(p => p.InformacionNinos)
                    .HasForeignKey(d => d.IdCodigoMedico)
                    .HasConstraintName("informacion_nino_ibfk_2");
            });

            modelBuilder.Entity<InventarioAlimentacion>(entity =>
            {
                entity.HasKey(e => e.PkCodigoAlimentacion)
                    .HasName("PRIMARY");

                entity.ToTable("inventario_alimentacion");

                entity.Property(e => e.PkCodigoAlimentacion)
                    .HasColumnType("int(11)")
                    .HasColumnName("pkCodigoAlimentacion");

                entity.Property(e => e.Adquisicion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Cantidad).HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.NombreBenefactor)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NombreBeneficiado)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InventarioInmueble>(entity =>
            {
                entity.HasKey(e => e.PkCodigoInmueble)
                    .HasName("PRIMARY");

                entity.ToTable("inventario_inmueble");

                entity.Property(e => e.PkCodigoInmueble)
                    .HasColumnType("int(11)")
                    .HasColumnName("pkCodigoInmueble");

                entity.Property(e => e.Adquisicion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Cantidad).HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.FechaAdquisicion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Valor).HasColumnType("int(11)");
            });

            modelBuilder.Entity<InventarioLimpieza>(entity =>
            {
                entity.HasKey(e => e.PkCodigoLimpieza)
                    .HasName("PRIMARY");

                entity.ToTable("inventario_limpieza");

                entity.Property(e => e.PkCodigoLimpieza)
                    .HasColumnType("int(11)")
                    .HasColumnName("pkCodigoLimpieza");

                entity.Property(e => e.Adquisicion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Cantidad).HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.NombreBenefactor)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NombreBeneficiado)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InventarioMueble>(entity =>
            {
                entity.HasKey(e => e.PkCodigoMueble)
                    .HasName("PRIMARY");

                entity.ToTable("inventario_mueble");

                entity.Property(e => e.PkCodigoMueble)
                    .HasColumnType("int(11)")
                    .HasColumnName("pkCodigoMueble");

                entity.Property(e => e.Adquisicion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Cantidad).HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.FechaAdquisicion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Placa).HasMaxLength(50);
            });

            modelBuilder.Entity<Proyecto>(entity =>
            {
                entity.HasKey(e => e.PkCodigoProyecto)
                    .HasName("PRIMARY");

                entity.ToTable("proyecto");

                entity.HasIndex(e => e.IdDetalleProyecto, "IdDetalleProyecto");

                entity.Property(e => e.PkCodigoProyecto)
                    .HasColumnType("int(11)")
                    .HasColumnName("pkCodigoProyecto");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.FechaInicioProyecto).HasColumnType("datetime");

                entity.Property(e => e.IdDetalleProyecto).HasColumnType("int(11)");

                entity.Property(e => e.NombreProyecto)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PresupuestoInicial).HasColumnType("int(11)");

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdDetalleProyectoNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.IdDetalleProyecto)
                    .HasConstraintName("proyecto_ibfk_1");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.PkRol)
                    .HasName("PRIMARY");

                entity.ToTable("rol");

                entity.HasIndex(e => e.Nombre, "Nombre")
                    .IsUnique();

                entity.Property(e => e.PkRol)
                    .HasColumnType("int(11)")
                    .HasColumnName("pkRol");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Socio>(entity =>
            {
                entity.HasKey(e => e.PkCedulaSocio)
                    .HasName("PRIMARY");

                entity.ToTable("socio");

                entity.Property(e => e.PkCedulaSocio)
                    .HasColumnType("int(11)")
                    .HasColumnName("pkCedulaSocio");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.DonacionMensual).HasColumnType("int(11)");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Provincia)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SegundoApellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono).HasColumnType("int(11)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
