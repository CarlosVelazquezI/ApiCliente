using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClashToday.CommonServices.PinValidator.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombrePais = table.Column<string>(type: "text", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "text", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ciudad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreCiudad = table.Column<string>(type: "text", nullable: false),
                    PaisId = table.Column<int>(type: "integer", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "text", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ciudad_Pais_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CveUsuario = table.Column<Guid>(type: "uuid", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Apellido = table.Column<string>(type: "text", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NumIdentificacion = table.Column<string>(type: "text", nullable: false),
                    TipoIdentificacion = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Telefono = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Direccion = table.Column<string>(type: "text", nullable: false),
                    CodigoPostal = table.Column<string>(type: "text", nullable: false),
                    CiudadId = table.Column<int>(type: "integer", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Ciudad_CiudadId",
                        column: x => x.CiudadId,
                        principalTable: "Ciudad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pais",
                columns: new[] { "Id", "Activo", "FechaCreacion", "FechaModificacion", "NombrePais", "UsuarioCreacion", "UsuarioModificacion" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6566), null, "Afganistán", "System", null },
                    { 2, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6754), null, "Albania", "System", null },
                    { 3, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6764), null, "Alemania", "System", null },
                    { 4, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6771), null, "Andorra", "System", null },
                    { 5, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6778), null, "Angola", "System", null },
                    { 6, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6787), null, "Antigua y Barbuda", "System", null },
                    { 7, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6794), null, "Arabia Saudita", "System", null },
                    { 8, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6801), null, "Argelia", "System", null },
                    { 9, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6807), null, "Argentina", "System", null },
                    { 10, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6814), null, "Armenia", "System", null },
                    { 11, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6821), null, "Australia", "System", null },
                    { 12, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6828), null, "Austria", "System", null },
                    { 13, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6834), null, "Azerbaiyán", "System", null },
                    { 14, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6841), null, "Bahamas", "System", null },
                    { 15, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6847), null, "Bahréin", "System", null },
                    { 16, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6855), null, "Bangladés", "System", null },
                    { 17, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6862), null, "Barbados", "System", null },
                    { 18, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6869), null, "Bielorrusia", "System", null },
                    { 19, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6876), null, "Bélgica", "System", null },
                    { 20, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6883), null, "Belice", "System", null },
                    { 21, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6890), null, "Benín", "System", null },
                    { 22, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6896), null, "Bhután", "System", null },
                    { 23, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6903), null, "Bolivia", "System", null },
                    { 24, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6910), null, "Bosnia y Herzegovina", "System", null },
                    { 25, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6916), null, "Botsuana", "System", null },
                    { 26, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6923), null, "Brasil", "System", null },
                    { 27, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6929), null, "Brunéi", "System", null },
                    { 28, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6935), null, "Bulgaria", "System", null },
                    { 29, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6941), null, "Burkina Faso", "System", null },
                    { 30, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6948), null, "Burundi", "System", null },
                    { 31, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6954), null, "Cabo Verde", "System", null },
                    { 32, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6960), null, "Camboya", "System", null },
                    { 33, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6967), null, "Camerún", "System", null },
                    { 34, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6975), null, "Canadá", "System", null },
                    { 35, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6982), null, "República Centroafricana", "System", null },
                    { 36, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6990), null, "Chad", "System", null },
                    { 37, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(6996), null, "Chile", "System", null },
                    { 38, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7003), null, "China", "System", null },
                    { 39, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7009), null, "Colombia", "System", null },
                    { 40, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7015), null, "Comoras", "System", null },
                    { 41, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7021), null, "Congo, República del", "System", null },
                    { 42, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7028), null, "Congo, República Democrática del", "System", null },
                    { 43, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7036), null, "Costa Rica", "System", null },
                    { 44, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7043), null, "Croacia", "System", null },
                    { 45, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7050), null, "Cuba", "System", null },
                    { 46, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7056), null, "Chipre", "System", null },
                    { 47, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7062), null, "República Checa", "System", null },
                    { 48, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7069), null, "Dinamarca", "System", null },
                    { 49, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7076), null, "Dominica", "System", null },
                    { 50, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7082), null, "República Dominicana", "System", null },
                    { 51, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7116), null, "Ecuador", "System", null },
                    { 52, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7122), null, "Egipto", "System", null },
                    { 53, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7130), null, "El Salvador", "System", null },
                    { 54, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7136), null, "Emiratos Árabes Unidos", "System", null },
                    { 55, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7143), null, "Equatorial Guinea", "System", null },
                    { 56, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7149), null, "Eritrea", "System", null },
                    { 57, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7155), null, "Eslovenia", "System", null },
                    { 58, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7162), null, "España", "System", null },
                    { 59, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7168), null, "Estados Unidos", "System", null },
                    { 60, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7175), null, "Estonia", "System", null },
                    { 61, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7181), null, "Eswatini", "System", null },
                    { 62, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7187), null, "Etiopía", "System", null },
                    { 63, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7193), null, "Filipinas", "System", null },
                    { 64, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7199), null, "Finlandia", "System", null },
                    { 65, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7205), null, "Francia", "System", null },
                    { 66, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7212), null, "Gambia", "System", null },
                    { 67, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7219), null, "Georgia", "System", null },
                    { 68, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7225), null, "Ghana", "System", null },
                    { 69, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7231), null, "Grecia", "System", null },
                    { 70, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7237), null, "Granada", "System", null },
                    { 71, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7243), null, "Guatemala", "System", null },
                    { 72, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7249), null, "Guyana", "System", null },
                    { 73, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7255), null, "Guinea", "System", null },
                    { 74, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7261), null, "Guinea-Bisáu", "System", null },
                    { 75, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7269), null, "Guinea Ecuatorial", "System", null },
                    { 76, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7275), null, "Haití", "System", null },
                    { 77, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7282), null, "Honduras", "System", null },
                    { 78, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7288), null, "Hungría", "System", null },
                    { 79, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7294), null, "India", "System", null },
                    { 80, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7300), null, "Indonesia", "System", null },
                    { 81, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7306), null, "Irak", "System", null },
                    { 82, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7312), null, "Irán", "System", null },
                    { 83, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7319), null, "Irlanda", "System", null },
                    { 84, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7325), null, "Islacia", "System", null },
                    { 85, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7331), null, "Islas Marshall", "System", null },
                    { 86, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7337), null, "Islas Salomón", "System", null },
                    { 87, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7343), null, "Islas Seychelles", "System", null },
                    { 88, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7350), null, "Italia", "System", null },
                    { 89, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7356), null, "Jamaica", "System", null },
                    { 90, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7362), null, "Japón", "System", null },
                    { 91, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7374), null, "Jordania", "System", null },
                    { 92, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7385), null, "Kazajistán", "System", null },
                    { 93, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7396), null, "Kenia", "System", null },
                    { 94, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7407), null, "Kirguistán", "System", null },
                    { 95, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7416), null, "Kiribati", "System", null },
                    { 96, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7425), null, "Kuwait", "System", null },
                    { 97, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7436), null, "Laos", "System", null },
                    { 98, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7446), null, "Latvia", "System", null },
                    { 99, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7456), null, "Líbano", "System", null },
                    { 100, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7467), null, "Liberia", "System", null },
                    { 101, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7481), null, "Libia", "System", null },
                    { 102, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7492), null, "Liechtenstein", "System", null },
                    { 103, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7503), null, "Lituania", "System", null },
                    { 104, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7514), null, "Luxemburgo", "System", null },
                    { 105, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7525), null, "Madagascar", "System", null },
                    { 106, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7565), null, "Malasia", "System", null },
                    { 107, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7572), null, "Malaui", "System", null },
                    { 108, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7578), null, "Maldivas", "System", null },
                    { 109, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7584), null, "Malta", "System", null },
                    { 110, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7590), null, "Marruecos", "System", null },
                    { 111, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7596), null, "Mauricio", "System", null },
                    { 112, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7602), null, "Mauritania", "System", null },
                    { 113, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7608), null, "México", "System", null },
                    { 114, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7615), null, "Micronesia", "System", null },
                    { 115, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7621), null, "Mónaco", "System", null },
                    { 116, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7627), null, "Mongolia", "System", null },
                    { 117, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7633), null, "Mozambique", "System", null },
                    { 118, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7639), null, "Namibia", "System", null },
                    { 119, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7645), null, "Nauru", "System", null },
                    { 120, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7651), null, "Nepal", "System", null },
                    { 121, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7657), null, "Nicaragua", "System", null },
                    { 122, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7663), null, "Nigeria", "System", null },
                    { 123, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7668), null, "Noruega", "System", null },
                    { 124, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7674), null, "Nueva Zelanda", "System", null },
                    { 125, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7680), null, "Omán", "System", null },
                    { 126, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7686), null, "Países Bajos", "System", null },
                    { 127, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7693), null, "Pakistán", "System", null },
                    { 128, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7699), null, "Panamá", "System", null },
                    { 129, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7706), null, "Paraguay", "System", null },
                    { 130, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7713), null, "Perú", "System", null },
                    { 131, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7719), null, "Polonia", "System", null },
                    { 132, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7725), null, "Portugal", "System", null },
                    { 133, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7731), null, "Reino Unido", "System", null },
                    { 134, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7737), null, "República del Congo", "System", null },
                    { 135, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7744), null, "República Dominicana", "System", null },
                    { 136, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7750), null, "Rumanía", "System", null },
                    { 137, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7756), null, "Rusia", "System", null },
                    { 138, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7762), null, "Rwanda", "System", null },
                    { 139, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7768), null, "San Cristóbal y Nieves", "System", null },
                    { 140, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7774), null, "San Marino", "System", null },
                    { 141, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7780), null, "San Vicente y las Granadinas", "System", null },
                    { 142, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7787), null, "Santo Tomé y Príncipe", "System", null },
                    { 143, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7793), null, "Senegal", "System", null },
                    { 144, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7799), null, "Serbia", "System", null },
                    { 145, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7805), null, "Seychelles", "System", null },
                    { 146, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7811), null, "Singapur", "System", null },
                    { 147, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7817), null, "Eslovaquia", "System", null },
                    { 148, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7823), null, "Eslovenia", "System", null },
                    { 149, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7829), null, "Somalia", "System", null },
                    { 150, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7835), null, "Sudáfrica", "System", null },
                    { 151, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7841), null, "Sudán", "System", null },
                    { 152, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7870), null, "Sudán del Sur", "System", null },
                    { 153, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7878), null, "Suecia", "System", null },
                    { 154, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7884), null, "Suiza", "System", null },
                    { 155, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7890), null, "Siria", "System", null },
                    { 156, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7896), null, "Tailandia", "System", null },
                    { 157, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7902), null, "Tanzania", "System", null },
                    { 158, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7908), null, "Timor Oriental", "System", null },
                    { 159, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7914), null, "Togo", "System", null },
                    { 160, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7920), null, "Tonga", "System", null },
                    { 161, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7926), null, "Trinidad y Tobago", "System", null },
                    { 162, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7932), null, "Túnez", "System", null },
                    { 163, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7938), null, "Turkmenistán", "System", null },
                    { 164, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7945), null, "Turquía", "System", null },
                    { 165, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7951), null, "Tuvalu", "System", null },
                    { 166, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7957), null, "Ucrania", "System", null },
                    { 167, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7963), null, "Uganda", "System", null },
                    { 168, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7969), null, "Uruguay", "System", null },
                    { 169, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7975), null, "Uzbekistán", "System", null },
                    { 170, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7981), null, "Vanuatu", "System", null },
                    { 171, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7987), null, "Vaticano", "System", null },
                    { 172, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7993), null, "Venezuela", "System", null },
                    { 173, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(7999), null, "Vietnam", "System", null },
                    { 174, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(8005), null, "Yemen", "System", null },
                    { 175, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(8012), null, "Zambia", "System", null },
                    { 176, true, new DateTime(2024, 10, 9, 8, 22, 45, 618, DateTimeKind.Utc).AddTicks(8017), null, "Zimbabue", "System", null }
                });

            migrationBuilder.InsertData(
                table: "Ciudad",
                columns: new[] { "Id", "Activo", "FechaCreacion", "FechaModificacion", "NombreCiudad", "PaisId", "UsuarioCreacion", "UsuarioModificacion" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2650), null, "Ciudad de México", 113, "System", null },
                    { 2, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2746), null, "Guadalajara", 113, "System", null },
                    { 3, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2761), null, "Monterrey", 113, "System", null },
                    { 4, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2770), null, "Puebla", 113, "System", null },
                    { 5, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2779), null, "Tijuana", 113, "System", null },
                    { 6, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2789), null, "León", 113, "System", null },
                    { 7, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2798), null, "Mérida", 113, "System", null },
                    { 8, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2807), null, "Cancún", 113, "System", null },
                    { 9, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2816), null, "San Luis Potosí", 113, "System", null },
                    { 10, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2826), null, "Querétaro", 113, "System", null },
                    { 11, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2835), null, "Veracruz", 113, "System", null },
                    { 12, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2864), null, "Chihuahua", 113, "System", null },
                    { 13, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2881), null, "Toluca", 113, "System", null },
                    { 14, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2896), null, "Saltillo", 113, "System", null },
                    { 15, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2910), null, "Aguascalientes", 113, "System", null },
                    { 16, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2924), null, "Hermosillo", 113, "System", null },
                    { 17, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2936), null, "La Paz", 113, "System", null },
                    { 18, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2951), null, "Matamoros", 113, "System", null },
                    { 19, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2965), null, "Culiacán", 113, "System", null },
                    { 20, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2979), null, "Durango", 113, "System", null },
                    { 21, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(2993), null, "Torreón", 113, "System", null },
                    { 22, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(3007), null, "Colima", 113, "System", null },
                    { 23, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(3020), null, "Oaxaca", 113, "System", null },
                    { 24, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(3034), null, "Tuxtla Gutiérrez", 113, "System", null },
                    { 25, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(3049), null, "Pachuca", 113, "System", null },
                    { 26, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(3063), null, "Irapuato", 113, "System", null },
                    { 27, true, new DateTime(2024, 10, 9, 8, 22, 45, 620, DateTimeKind.Utc).AddTicks(3075), null, "Cabo San Lucas", 113, "System", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ciudad_PaisId",
                table: "Ciudad",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_CiudadId",
                table: "Cliente",
                column: "CiudadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Ciudad");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
