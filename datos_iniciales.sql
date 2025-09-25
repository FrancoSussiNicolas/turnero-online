USE [turnero_db]
GO

DECLARE @SALT NVARCHAR(MAX) = '9otENYoBq+zoWk+sZK+2Z7g0Wgh/PhVqQyRYUCXFGeM=';
DECLARE @HASHED_PASS NVARCHAR(MAX) = '6hfbDvAXaxv6JFbX90fzMCO+k6KyhrFV15+zcYloc/I=';
DECLARE @ESTADO_INICIAL INT = 0;

DELETE FROM [dbo].[Turnos];
DELETE FROM [dbo].[PlanPractica];
DELETE FROM [dbo].[ProfesionalObraSocial];

DELETE FROM [dbo].[Pacientes];
DELETE FROM [dbo].[Profesionales];
DELETE FROM [dbo].[PlanesObrasSociales];

DELETE FROM [dbo].[Practicas];
DELETE FROM [dbo].[ObrasSociales];
DELETE FROM [dbo].[Especialidades];
DELETE FROM [dbo].[Consultorios];

DBCC CHECKIDENT ('[dbo].[Turnos]', RESEED, 0);
DBCC CHECKIDENT ('[dbo].[Pacientes]', RESEED, 0);
DBCC CHECKIDENT ('[dbo].[Profesionales]', RESEED, 0);
DBCC CHECKIDENT ('[dbo].[PlanesObrasSociales]', RESEED, 0);
DBCC CHECKIDENT ('[dbo].[Practicas]', RESEED, 0);
DBCC CHECKIDENT ('[dbo].[ObrasSociales]', RESEED, 0);
DBCC CHECKIDENT ('[dbo].[Especialidades]', RESEED, 0);
DBCC CHECKIDENT ('[dbo].[Consultorios]', RESEED, 0);

INSERT INTO [dbo].[Consultorios] ([Ubicacion], [Estado])
VALUES
('Consultorio 1A', @ESTADO_INICIAL), ('Consultorio 1B', @ESTADO_INICIAL), ('Consultorio 2A', @ESTADO_INICIAL),
('Consultorio 2B', @ESTADO_INICIAL), ('Consultorio 3A', @ESTADO_INICIAL), ('Consultorio 3B', @ESTADO_INICIAL),
('Consultorio 4A', @ESTADO_INICIAL), ('Consultorio 4B', @ESTADO_INICIAL), ('Consultorio 5A', @ESTADO_INICIAL),
('Consultorio 5B', @ESTADO_INICIAL);

INSERT INTO [dbo].[Especialidades] ([Descripcion], [Estado])
VALUES
('Cardiología', @ESTADO_INICIAL), ('Dermatología', @ESTADO_INICIAL), ('Gastroenterología', @ESTADO_INICIAL),
('Pediatría', @ESTADO_INICIAL), ('Oftalmología', @ESTADO_INICIAL), ('Neurología', @ESTADO_INICIAL),
('Odontología', @ESTADO_INICIAL), ('Traumatología', @ESTADO_INICIAL), ('Ginecología', @ESTADO_INICIAL),
('Urología', @ESTADO_INICIAL);

INSERT INTO [dbo].[ObrasSociales] ([NombreObraSocial], [Estado])
VALUES
('Osde', @ESTADO_INICIAL), ('Swiss Medical', @ESTADO_INICIAL), ('Galeno', @ESTADO_INICIAL),
('Medicus', @ESTADO_INICIAL), ('Hospital Italiano', @ESTADO_INICIAL), ('Omint', @ESTADO_INICIAL),
('Aca Salud', @ESTADO_INICIAL), ('Premedic', @ESTADO_INICIAL), ('Prevención Salud', @ESTADO_INICIAL),
('Cobertura Médica', @ESTADO_INICIAL);

INSERT INTO [dbo].[Practicas] ([Nombre], [Descripcion], [Estado])
VALUES
('Electrocardiograma', 'Registro de la actividad eléctrica del corazón.', @ESTADO_INICIAL),
('Control Dermatológico', 'Chequeo de la piel para detectar anomalías.', @ESTADO_INICIAL),
('Endoscopía Digestiva', 'Examen del tracto gastrointestinal superior.', @ESTADO_INICIAL),
('Control de Niño Sano', 'Evaluación periódica del crecimiento y desarrollo.', @ESTADO_INICIAL),
('Fondo de Ojo', 'Revisión de las estructuras internas del ojo.', @ESTADO_INICIAL),
('Electromiografía', 'Estudio de la salud muscular y nerviosa.', @ESTADO_INICIAL),
('Limpieza Dental', 'Eliminación de placa y sarro.', @ESTADO_INICIAL),
('Radiografía de Rodilla', 'Diagnóstico de lesiones óseas en la rodilla.', @ESTADO_INICIAL),
('Papanicolau', 'Examen para la detección temprana de cáncer de cuello uterino.', @ESTADO_INICIAL),
('Ecografía Renal', 'Visualización de los riñones y vías urinarias.', @ESTADO_INICIAL);

INSERT INTO [dbo].[PlanesObrasSociales] ([NombrePlan], [DescripcionPlan], [Estado], [ObraSocialId])
VALUES
('Plan Azul', 'Cobertura Básica', @ESTADO_INICIAL, 1), ('Plan Plata', 'Cobertura Media', @ESTADO_INICIAL, 1), ('Plan Oro', 'Cobertura Premium', @ESTADO_INICIAL, 1),
('Plan 1', 'Plan inicial', @ESTADO_INICIAL, 2), ('Plan 2', 'Plan intermedio', @ESTADO_INICIAL, 2), ('Plan 3', 'Plan completo', @ESTADO_INICIAL, 2),
('Plan A', 'Plan básico', @ESTADO_INICIAL, 3), ('Plan B', 'Plan estándar', @ESTADO_INICIAL, 3), ('Plan C', 'Plan superior', @ESTADO_INICIAL, 3),
('Plan F', 'Plan familiar', @ESTADO_INICIAL, 4), ('Plan I', 'Plan individual', @ESTADO_INICIAL, 4), ('Plan P', 'Plan profesional', @ESTADO_INICIAL, 4),
('Plan Mi Salud', 'Plan con coseguro', @ESTADO_INICIAL, 5), ('Plan Max', 'Sin coseguro', @ESTADO_INICIAL, 5), ('Plan Premium', 'Internacional', @ESTADO_INICIAL, 5),
('Plan Joven', 'Para 18 a 30', @ESTADO_INICIAL, 6), ('Plan Clásico', 'Para todas las edades', @ESTADO_INICIAL, 6), ('Plan Senior', 'Para adultos mayores', @ESTADO_INICIAL, 6),
('Plan Único', 'Plan general', @ESTADO_INICIAL, 7), ('Plan Selecto', 'Plan con descuentos', @ESTADO_INICIAL, 7), ('Plan Élite', 'Plan sin límites', @ESTADO_INICIAL, 7),
('Plan 100', 'Cobertura regional', @ESTADO_INICIAL, 8), ('Plan 200', 'Cobertura nacional', @ESTADO_INICIAL, 8), ('Plan 300', 'Cobertura con reintegros', @ESTADO_INICIAL, 8),
('Plan Básico', 'Plan económico', @ESTADO_INICIAL, 9), ('Plan Intermedio', 'Plan completo', @ESTADO_INICIAL, 9), ('Plan Total', 'Plan sin restricciones', @ESTADO_INICIAL, 9),
('Plan de Salud A', 'Plan para empresas', @ESTADO_INICIAL, 10), ('Plan de Salud B', 'Plan para particulares', @ESTADO_INICIAL, 10), ('Plan de Salud C', 'Plan familiar', @ESTADO_INICIAL, 10);

INSERT INTO [dbo].[Profesionales] ([Matricula], [EspecialidadId], [Estado], [ApellidoNombre], [Mail], [Contrasenia], [Salt])
VALUES
('MP-12345', 1, @ESTADO_INICIAL, 'García Pérez, Dr. Alberto', 'a.garcia@test.com', @HASHED_PASS, @SALT),
('MP-23456', 2, @ESTADO_INICIAL, 'López Gómez, Dra. María', 'm.lopez@test.com', @HASHED_PASS, @SALT),
('MP-34567', 3, @ESTADO_INICIAL, 'Martínez Sánchez, Dr. Pedro', 'p.martinez@test.com', @HASHED_PASS, @SALT),
('MP-45678', 4, @ESTADO_INICIAL, 'Fernández Ruiz, Dra. Laura', 'l.fernandez@test.com', @HASHED_PASS, @SALT),
('MP-56789', 5, @ESTADO_INICIAL, 'Gómez Varela, Dra. Sofía', 's.gomez@test.com', @HASHED_PASS, @SALT),
('MP-67890', 6, @ESTADO_INICIAL, 'Sánchez Torres, Dr. Manuel', 'm.sanchez@test.com', @HASHED_PASS, @SALT),
('MP-78901', 7, @ESTADO_INICIAL, 'Ramírez Castro, Dra. Ana', 'a.ramirez@test.com', @HASHED_PASS, @SALT),
('MP-89012', 8, @ESTADO_INICIAL, 'Díaz Herrera, Dr. Javier', 'j.diaz@test.com', @HASHED_PASS, @SALT),
('MP-90123', 9, @ESTADO_INICIAL, 'Ruiz Martín, Dra. Valeria', 'v.ruiz@test.com', @HASHED_PASS, @SALT),
('MP-01234', 10, @ESTADO_INICIAL, 'Castro Gil, Dr. Ricardo', 'r.castro@test.com', @HASHED_PASS, @SALT);

INSERT INTO [dbo].[Pacientes] ([Dni], [Sexo], [FechaNacimiento], [Telefono], [PlanObraSocialId], [ApellidoNombre], [Mail], [Contrasenia], [Salt])
VALUES
('11222333', 'Masculino', '1985-05-15', '3411234567', 1, 'Pérez Juan', 'juan.perez@test.com', @HASHED_PASS, @SALT),
('22333444', 'Femenino', '1990-11-20', '3412345678', 2, 'Gómez Ana', 'ana.gomez@test.com', @HASHED_PASS, @SALT),
('33444555', 'Masculino', '1978-02-10', '3413456789', 3, 'López Carlos', 'carlos.lopez@test.com', @HASHED_PASS, @SALT),
('44555666', 'Femenino', '2001-07-25', '3414567890', 4, 'Martínez Sofía', 'sofia.martinez@test.com', @HASHED_PASS, @SALT),
('55666777', 'Masculino', '1965-09-03', '3415678901', 5, 'Rodríguez Luis', 'luis.rodriguez@test.com', @HASHED_PASS, @SALT),
('66777888', 'Femenino', '1995-04-18', '3416789012', 6, 'Fernández Laura', 'laura.fernandez@test.com', @HASHED_PASS, @SALT),
('77888999', 'Masculino', '1982-12-01', '3417890123', 7, 'García Manuel', 'manuel.garcia@test.com', @HASHED_PASS, @SALT),
('88999000', 'Femenino', '1970-06-08', '3418901234', 8, 'Díaz Patricia', 'patricia.diaz@test.com', @HASHED_PASS, @SALT),
('99000111', 'Masculino', '1998-03-22', '3419012345', 9, 'Sánchez Pablo', 'pablo.sanchez@test.com', @HASHED_PASS, @SALT),
('00111222', 'Femenino', '1980-10-30', '3410123456', 10, 'Ramírez Belén', 'belen.ramirez@test.com', @HASHED_PASS, @SALT);

INSERT INTO [dbo].[Turnos] ([FechaTurno], [HoraTurno], [Estado], [ConsultorioId], [PacienteId], [ProfesionalId])
VALUES
('2025-10-01', '09:00:00', @ESTADO_INICIAL, 1, 1, 1), ('2025-10-01', '09:30:00', @ESTADO_INICIAL, 2, 2, 2),
('2025-10-02', '10:00:00', @ESTADO_INICIAL, 3, 3, 3), ('2025-10-02', '11:00:00', @ESTADO_INICIAL, 4, 4, 4),
('2025-10-03', '11:30:00', @ESTADO_INICIAL, 5, 5, 5), ('2025-10-03', '14:00:00', @ESTADO_INICIAL, 6, 6, 6),
('2025-10-04', '14:30:00', @ESTADO_INICIAL, 7, 7, 7), ('2025-10-04', '16:00:00', @ESTADO_INICIAL, 8, 8, 8),
('2025-10-05', '16:30:00', @ESTADO_INICIAL, 9, 9, 9), ('2025-10-05', '17:00:00', @ESTADO_INICIAL, 10, 10, 10);

INSERT INTO [dbo].[PlanPractica] ([PlanObraSocialId], [PracticaId])
VALUES
(1, 1), (2, 2), (3, 3), (4, 4), (5, 5), (6, 6), (7, 7), (8, 8), (9, 9), (10, 10);

INSERT INTO [dbo].[ProfesionalObraSocial] ([ObraSocialesObraSocialId], [ProfesionalPersonaId])
VALUES
(1, 1), (2, 2), (3, 3), (4, 4), (5, 5), (6, 6), (7, 7), (8, 8), (9, 9), (10, 10);