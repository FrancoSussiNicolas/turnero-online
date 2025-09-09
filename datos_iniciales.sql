USE [turnero_db]
GO

-- Limpiar las tablas para evitar duplicados en caso de re-ejecución
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

-- Inserción de datos en orden correcto

-- 10 Consultorios
INSERT INTO [dbo].[Consultorios] ([Ubicacion], [Estado])
VALUES
('Consultorio 1A', 1),
('Consultorio 1B', 1),
('Consultorio 2A', 1),
('Consultorio 2B', 1),
('Consultorio 3A', 1),
('Consultorio 3B', 1),
('Consultorio 4A', 1),
('Consultorio 4B', 1),
('Consultorio 5A', 1),
('Consultorio 5B', 1);

-- 10 Especialidades
INSERT INTO [dbo].[Especialidades] ([Descripcion], [Estado])
VALUES
('Cardiología', 1),
('Dermatología', 1),
('Gastroenterología', 1),
('Pediatría', 1),
('Oftalmología', 1),
('Neurología', 1),
('Odontología', 1),
('Traumatología', 1),
('Ginecología', 1),
('Urología', 1);

-- 10 Obras Sociales
INSERT INTO [dbo].[ObrasSociales] ([NombreObraSocial])
VALUES
('Osde'),
('Swiss Medical'),
('Galeno'),
('Medicus'),
('Hospital Italiano'),
('Omint'),
('Aca Salud'),
('Premedic'),
('Prevención Salud'),
('Cobertura Médica');

-- 10 Prácticas
INSERT INTO [dbo].[Practicas] ([Nombre], [Descripcion], [Estado])
VALUES
('Electrocardiograma', 'Registro de la actividad eléctrica del corazón.', 1),
('Control Dermatológico', 'Chequeo de la piel para detectar anomalías.', 1),
('Endoscopía Digestiva', 'Examen del tracto gastrointestinal superior.', 1),
('Control de Niño Sano', 'Evaluación periódica del crecimiento y desarrollo.', 1),
('Fondo de Ojo', 'Revisión de las estructuras internas del ojo.', 1),
('Electromiografía', 'Estudio de la salud muscular y nerviosa.', 1),
('Limpieza Dental', 'Eliminación de placa y sarro.', 1),
('Radiografía de Rodilla', 'Diagnóstico de lesiones óseas en la rodilla.', 1),
('Papanicolau', 'Examen para la detección temprana de cáncer de cuello uterino.', 1),
('Ecografía Renal', 'Visualización de los riñones y vías urinarias.', 1);

-- 30 Planes de Obras Sociales (3 por cada obra social)
INSERT INTO [dbo].[PlanesObrasSociales] ([NombrePlan], [DescripcionPlan], [ObraSocialId])
VALUES
('Plan Azul', 'Cobertura Básica', 1), ('Plan Plata', 'Cobertura Media', 1), ('Plan Oro', 'Cobertura Premium', 1),
('Plan 1', 'Plan inicial', 2), ('Plan 2', 'Plan intermedio', 2), ('Plan 3', 'Plan completo', 2),
('Plan A', 'Plan básico', 3), ('Plan B', 'Plan estándar', 3), ('Plan C', 'Plan superior', 3),
('Plan F', 'Plan familiar', 4), ('Plan I', 'Plan individual', 4), ('Plan P', 'Plan profesional', 4),
('Plan Mi Salud', 'Plan con coseguro', 5), ('Plan Max', 'Sin coseguro', 5), ('Plan Premium', 'Internacional', 5),
('Plan Joven', 'Para 18 a 30', 6), ('Plan Clásico', 'Para todas las edades', 6), ('Plan Senior', 'Para adultos mayores', 6),
('Plan Único', 'Plan general', 7), ('Plan Selecto', 'Plan con descuentos', 7), ('Plan Élite', 'Plan sin límites', 7),
('Plan 100', 'Cobertura regional', 8), ('Plan 200', 'Cobertura nacional', 8), ('Plan 300', 'Cobertura con reintegros', 8),
('Plan Básico', 'Plan económico', 9), ('Plan Intermedio', 'Plan completo', 9), ('Plan Total', 'Plan sin restricciones', 9),
('Plan de Salud A', 'Plan para empresas', 10), ('Plan de Salud B', 'Plan para particulares', 10), ('Plan de Salud C', 'Plan familiar', 10);

-- 10 Profesionales
INSERT INTO [dbo].[Profesionales] ([Matricula], [EspecialidadId], [ApellidoNombre], [Mail], [Contrasenia])
VALUES
('MP-12345', 1, 'García Pérez, Dr. Alberto', 'a.garcia@test.com', 'pass123'),
('MP-23456', 2, 'López Gómez, Dra. María', 'm.lopez@test.com', 'pass123'),
('MP-34567', 3, 'Martínez Sánchez, Dr. Pedro', 'p.martinez@test.com', 'pass123'),
('MP-45678', 4, 'Fernández Ruiz, Dra. Laura', 'l.fernandez@test.com', 'pass123'),
('MP-56789', 5, 'Gómez Varela, Dra. Sofía', 's.gomez@test.com', 'pass123'),
('MP-67890', 6, 'Sánchez Torres, Dr. Manuel', 'm.sanchez@test.com', 'pass123'),
('MP-78901', 7, 'Ramírez Castro, Dra. Ana', 'a.ramirez@test.com', 'pass123'),
('MP-89012', 8, 'Díaz Herrera, Dr. Javier', 'j.diaz@test.com', 'pass123'),
('MP-90123', 9, 'Ruiz Martín, Dra. Valeria', 'v.ruiz@test.com', 'pass123'),
('MP-01234', 10, 'Castro Gil, Dr. Ricardo', 'r.castro@test.com', 'pass123');

-- 10 Pacientes
INSERT INTO [dbo].[Pacientes] ([Dni], [Sexo], [FechaNacimiento], [Telefono], [PlanObraSocialId], [ApellidoNombre], [Mail], [Contrasenia])
VALUES
('11222333', 'Masculino', '1985-05-15', '3411234567', 1, 'Pérez Juan', 'juan.perez@test.com', 'pass123'),
('22333444', 'Femenino', '1990-11-20', '3412345678', 2, 'Gómez Ana', 'ana.gomez@test.com', 'pass123'),
('33444555', 'Masculino', '1978-02-10', '3413456789', 3, 'López Carlos', 'carlos.lopez@test.com', 'pass123'),
('44555666', 'Femenino', '2001-07-25', '3414567890', 4, 'Martínez Sofía', 'sofia.martinez@test.com', 'pass123'),
('55666777', 'Masculino', '1965-09-03', '3415678901', 5, 'Rodríguez Luis', 'luis.rodriguez@test.com', 'pass123'),
('66777888', 'Femenino', '1995-04-18', '3416789012', 6, 'Fernández Laura', 'laura.fernandez@test.com', 'pass123'),
('77888999', 'Masculino', '1982-12-01', '3417890123', 7, 'García Manuel', 'manuel.garcia@test.com', 'pass123'),
('88999000', 'Femenino', '1970-06-08', '3418901234', 8, 'Díaz Patricia', 'patricia.diaz@test.com', 'pass123'),
('99000111', 'Masculino', '1998-03-22', '3419012345', 9, 'Sánchez Pablo', 'pablo.sanchez@test.com', 'pass123'),
('00111222', 'Femenino', '1980-10-30', '3410123456', 10, 'Ramírez Belén', 'belen.ramirez@test.com', 'pass123');

-- 10 Turnos
INSERT INTO [dbo].[Turnos] ([FechaTurno], [HoraTurno], [Estado], [ConsultorioId], [PacienteId], [ProfesionalId])
VALUES
('2025-09-15', '09:00:00', 1, 1, 1, 1),
('2025-09-15', '09:30:00', 1, 2, 2, 2),
('2025-09-15', '10:00:00', 1, 3, 3, 3),
('2025-09-16', '11:00:00', 1, 4, 4, 4),
('2025-09-16', '11:30:00', 1, 5, 5, 5),
('2025-09-17', '14:00:00', 1, 6, 6, 6),
('2025-09-17', '14:30:00', 1, 7, 7, 7),
('2025-09-18', '16:00:00', 1, 8, 8, 8),
('2025-09-18', '16:30:00', 1, 9, 9, 9),
('2025-09-19', '17:00:00', 1, 10, 10, 10);

-- 10 relaciones Plan con Práctica
INSERT INTO [dbo].[PlanPractica] ([PlanObraSocialId], [PracticaId])
VALUES
(1, 1), (2, 2), (3, 3), (4, 4), (5, 5), (6, 6), (7, 7), (8, 8), (9, 9), (10, 10);

-- 10 relación Profesional con Obra Social
INSERT INTO [dbo].[ProfesionalObraSocial] ([ObraSocialesObraSocialId], [ProfesionalPersonaId])
VALUES
(1, 1), (2, 2), (3, 3), (4, 4), (5, 5), (6, 6), (7, 7), (8, 8), (9, 9), (10, 10);