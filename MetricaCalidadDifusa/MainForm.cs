/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 07-09-2016
 * Hora: 15:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FuzzyCore;

namespace MetricaCalidadDifusa
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class FrmMain : Form
	{
		VariableDifusa facilidad_de_operacion;
		VariableDifusa formacion;
		VariableDifusa seguridad;
		VariableDifusa facilidad_de_comunicacion;
		VariableDifusa facilidad_de_aprendizaje;
		VariableDifusa facilidad_de_auditoria;
		VariableDifusa completitud;
		VariableDifusa consistencia;
		VariableDifusa trazabilidad;
		VariableDifusa precision;
		VariableDifusa tolerancia_a_fallas;
		VariableDifusa exactitud;
		VariableDifusa auto_descripcion;
		VariableDifusa instrumentacion;
		VariableDifusa modularidad;
		VariableDifusa simplicidad;
		VariableDifusa consicion;
		VariableDifusa capacidad_de_expansion;
		VariableDifusa generalidad;
		VariableDifusa compatibilidad_de_comunicacion;
		VariableDifusa compatibilidad_de_datos;
		VariableDifusa estandarizacion_de_datos;
		VariableDifusa eficiencia_de_ejecucion;
		VariableDifusa eficiencia_de_almacenamiento;
		VariableDifusa control_de_acceso;
		VariableDifusa independencia_de_software;
		VariableDifusa independencia_del_hardware;
		VariableDifusa facilidad_de_uso;
		VariableDifusa integridad;
		VariableDifusa correcion;
		VariableDifusa eficiencia;
		VariableDifusa fiabilidad;
		VariableDifusa facilidad_de_mantenimiento;
		VariableDifusa facilidad_de_prueba;
		VariableDifusa flexibilidad;
		VariableDifusa reusabilidad;
		VariableDifusa interoperabilidad;
		VariableDifusa portabilidad;
		VariableDifusa operacion_del_producto;
		VariableDifusa revision_del_producto;
		VariableDifusa transicion_del_producto;
		VariableDifusa calidad_de_software;
		
		InferenciaDifusa infFacilidadUso;
		InferenciaDifusa infIntegridad;
		InferenciaDifusa infCorrecion;
		InferenciaDifusa infFiabilidad;
		InferenciaDifusa infEficiencia;
		InferenciaDifusa infFacilidadMantenimiento;
		InferenciaDifusa infFacilidadPrueba;
		InferenciaDifusa infFLexibilidad;
		InferenciaDifusa infReusabilidad;
		InferenciaDifusa infInteroperabilidad;
		InferenciaDifusa infPortabilidad;
		InferenciaDifusa infOperacion;
		InferenciaDifusa infRevision;
		InferenciaDifusa infTransicion;
		InferenciaDifusa infCalidadSoftware;
		
		String pathReglas;
		
		
	/***************************************************************************/
		public FrmMain()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			inicializarVariables();
			inicializarInferencia();

		}
	/***************************************************************************/	
		public void inicializarVariables()
		{
			
			facilidad_de_operacion = new VariableDifusa("facilidad_de_operacion", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});	
			formacion = new VariableDifusa("formacion", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});
			seguridad = new VariableDifusa("seguridad", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});
			//----------------------------------------------------------------		
			facilidad_de_comunicacion = new VariableDifusa("facilidad_de_comunicacion", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_dificil", 0, 2, 4),
				new FuncionTriangular("dificil", 2, 4, 6),
				new FuncionTriangular("normal", 4, 6, 8),
				new FuncionTriangular("facil", 6, 8, 10),
				new FuncionSaturacion("muy_facil", 8, 10, 10)
			});
			facilidad_de_aprendizaje = new VariableDifusa("facilidad_de_aprendizaje", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_dificil", 0, 2, 4),
				new FuncionTriangular("dificil", 2, 4, 6),
				new FuncionTriangular("normal", 4, 6, 8),
				new FuncionTriangular("facil", 6, 8, 10),
				new FuncionSaturacion("muy_facil", 8, 10, 10)
			});			
			facilidad_de_auditoria = new VariableDifusa("facilidad_de_auditoria", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_dificil", 0, 2, 4),
				new FuncionTriangular("dificil", 2, 4, 6),
				new FuncionTriangular("normal", 4, 6, 8),
				new FuncionTriangular("facil", 6, 8, 10),
				new FuncionSaturacion("muy_facil", 8, 10, 10)
			});
			//----------------------------------------------------------------	
			completitud = new VariableDifusa("completitud", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("nunca", 0, 2, 4),
				new FuncionTriangular("pocas_veces", 2, 4, 6),
				new FuncionTriangular("algunas_veces", 4, 6, 8),
				new FuncionTriangular("casi_siempre", 6, 8, 10),
				new FuncionSaturacion("siempre", 8, 10, 10)
			});
			consistencia = new VariableDifusa("consistencia", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("nunca", 0, 2, 4),
				new FuncionTriangular("pocas_veces", 2, 4, 6),
				new FuncionTriangular("algunas_veces", 4, 6, 8),
				new FuncionTriangular("casi_siempre", 6, 8, 10),
				new FuncionSaturacion("siempre", 8, 10, 10)
			});
			trazabilidad = new VariableDifusa("trazabilidad", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("nunca", 0, 2, 4),
				new FuncionTriangular("pocas_veces", 2, 4, 6),
				new FuncionTriangular("algunas_veces", 4, 6, 8),
				new FuncionTriangular("casi_siempre", 6, 8, 10),
				new FuncionSaturacion("siempre", 8, 10, 10)
			});
			precision = new VariableDifusa("precision", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("nunca", 0, 2, 4),
				new FuncionTriangular("pocas_veces", 2, 4, 6),
				new FuncionTriangular("algunas_veces", 4, 6, 8),
				new FuncionTriangular("casi_siempre", 6, 8, 10),
				new FuncionSaturacion("siempre", 8, 10, 10)
			});
			tolerancia_a_fallas = new VariableDifusa("tolerancia_a_fallas", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("nunca", 0, 2, 4),
				new FuncionTriangular("pocas_veces", 2, 4, 6),
				new FuncionTriangular("algunas_veces", 4, 6, 8),
				new FuncionTriangular("casi_siempre", 6, 8, 10),
				new FuncionSaturacion("siempre", 8, 10, 10)
			});
			exactitud = new VariableDifusa("exactitud", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("nunca", 0, 2, 4),
				new FuncionTriangular("pocas_veces", 2, 4, 6),
				new FuncionTriangular("algunas_veces", 4, 6, 8),
				new FuncionTriangular("casi_siempre", 6, 8, 10),
				new FuncionSaturacion("siempre", 8, 10, 10)
			});
			auto_descripcion = new VariableDifusa("auto_descripcion", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("nunca", 0, 2, 4),
				new FuncionTriangular("pocas_veces", 2, 4, 6),
				new FuncionTriangular("algunas_veces", 4, 6, 8),
				new FuncionTriangular("casi_siempre", 6, 8, 10),
				new FuncionSaturacion("siempre", 8, 10, 10)
			});
			instrumentacion = new VariableDifusa("instrumentacion", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("nunca", 0, 2, 4),
				new FuncionTriangular("pocas_veces", 2, 4, 6),
				new FuncionTriangular("algunas_veces", 4, 6, 8),
				new FuncionTriangular("casi_siempre", 6, 8, 10),
				new FuncionSaturacion("siempre", 8, 10, 10)
			});
			//----------------------------------------------------------------	
			modularidad = new VariableDifusa("modularidad", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("no", 0, 2, 4),
				new FuncionTriangular("poco", 2, 4, 6),
				new FuncionTriangular("medianamente", 4, 6, 8),
				new FuncionTriangular("casi_todo", 6, 8, 10),
				new FuncionSaturacion("completamente", 8, 10, 10)
			});
			simplicidad = new VariableDifusa("simplicidad", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("no", 0, 2, 4),
				new FuncionTriangular("poco", 2, 4, 6),
				new FuncionTriangular("medianamente", 4, 6, 8),
				new FuncionTriangular("casi_todo", 6, 8, 10),
				new FuncionSaturacion("completamente", 8, 10, 10)
			});
			consicion = new VariableDifusa("consicion", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("no", 0, 2, 4),
				new FuncionTriangular("poco", 2, 4, 6),
				new FuncionTriangular("medianamente", 4, 6, 8),
				new FuncionTriangular("casi_todo", 6, 8, 10),
				new FuncionSaturacion("completamente", 8, 10, 10)
			});
			capacidad_de_expansion = new VariableDifusa("capacidad_de_expansion", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("no", 0, 2, 4),
				new FuncionTriangular("poco", 2, 4, 6),
				new FuncionTriangular("medianamente", 4, 6, 8),
				new FuncionTriangular("casi_todo", 6, 8, 10),
				new FuncionSaturacion("completamente", 8, 10, 10)
			});
			generalidad = new VariableDifusa("generalidad", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("no", 0, 2, 4),
				new FuncionTriangular("poco", 2, 4, 6),
				new FuncionTriangular("medianamente", 4, 6, 8),
				new FuncionTriangular("casi_todo", 6, 8, 10),
				new FuncionSaturacion("completamente", 8, 10, 10)
			});
			compatibilidad_de_comunicacion = new VariableDifusa("compatibilidad_de_comunicacion", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("no", 0, 2, 4),
				new FuncionTriangular("poco", 2, 4, 6),
				new FuncionTriangular("medianamente", 4, 6, 8),
				new FuncionTriangular("casi_todo", 6, 8, 10),
				new FuncionSaturacion("completamente", 8, 10, 10)
			});
			compatibilidad_de_datos = new VariableDifusa("compatibilidad_de_datos", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("no", 0, 2, 4),
				new FuncionTriangular("poco", 2, 4, 6),
				new FuncionTriangular("medianamente", 4, 6, 8),
				new FuncionTriangular("casi_todo", 6, 8, 10),
				new FuncionSaturacion("completamente", 8, 10, 10)
			});
			estandarizacion_de_datos = new VariableDifusa("estandarizacion_de_datos", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("no", 0, 2, 4),
				new FuncionTriangular("poco", 2, 4, 6),
				new FuncionTriangular("medianamente", 4, 6, 8),
				new FuncionTriangular("casi_todo", 6, 8, 10),
				new FuncionSaturacion("completamente", 8, 10, 10)
			});
			//----------------------------------------------------------------	
			eficiencia_de_ejecucion = new VariableDifusa("eficiencia_de_ejecucion", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("no_tiene", 0, 2, 4),
				new FuncionTriangular("basica", 2, 4, 6),
				new FuncionTriangular("mediana", 4, 6, 8),
				new FuncionTriangular("alta", 6, 8, 10),
				new FuncionSaturacion("muy_alta", 8, 10, 10)
			});
			eficiencia_de_almacenamiento = new VariableDifusa("eficiencia_de_almacenamiento", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("no_tiene", 0, 2, 4),
				new FuncionTriangular("basica", 2, 4, 6),
				new FuncionTriangular("mediana", 4, 6, 8),
				new FuncionTriangular("alta", 6, 8, 10),
				new FuncionSaturacion("muy_alta", 8, 10, 10)
			});
			//----------------------------------------------------------------
			control_de_acceso = new VariableDifusa("Control_de_acceso", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("no", 0, 0, 1),
				new FuncionSaturacion("si", 9, 10, 10)
			});
			independencia_de_software = new VariableDifusa("independencia_de_software", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("no", 0, 0, 1),
				new FuncionSaturacion("si", 9, 10, 10)
			});
			independencia_del_hardware = new VariableDifusa("independencia_del_hardware", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("no", 0, 0, 1),
				new FuncionSaturacion("si", 9, 10, 10)
			});
			//*****************************************************************************
			facilidad_de_uso = new VariableDifusa("facilidad_de_uso", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});				
			integridad = new VariableDifusa("integridad", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});	
			correcion = new VariableDifusa("correcion", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});	
			fiabilidad = new VariableDifusa("fiabilidad", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});	
			eficiencia = new VariableDifusa("eficiencia", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});	
			facilidad_de_mantenimiento = new VariableDifusa("facilidad_de_mantenimiento", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});	
			facilidad_de_prueba = new VariableDifusa("facilidad_de_prueba", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});	
			flexibilidad = new VariableDifusa("flexibilidad", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});	
			reusabilidad = new VariableDifusa("reusabilidad", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});	
			interoperabilidad = new VariableDifusa("interoperabilidad", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});	
			portabilidad = new VariableDifusa("portabilidad", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});	
			/*******************************************************************************************/
			
			operacion_del_producto = new VariableDifusa("operacion_del_producto", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});	
			revision_del_producto = new VariableDifusa("revision_del_producto", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});	
			transicion_del_producto = new VariableDifusa("transicion_del_producto", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});	
			
			calidad_de_software = new VariableDifusa("calidad_de_software", 0, 10, new List<FuncionPertenencia> {
				new FuncionHombro("muy_mala", 0, 2, 4),
				new FuncionTriangular("mala", 2, 4, 6),
				new FuncionTriangular("promedio", 4, 6, 8),
				new FuncionTriangular("buena", 6, 8, 10),
				new FuncionSaturacion("excelente", 8, 10, 10)
			});	
		}
	/***************************************************************************/	
		public void inicializarInferencia(){
			
			infFacilidadUso = new InferenciaDifusa();
			infIntegridad = new InferenciaDifusa();
			infCorrecion = new InferenciaDifusa();
			infFiabilidad = new InferenciaDifusa();
			infEficiencia = new InferenciaDifusa();
			infFacilidadMantenimiento = new InferenciaDifusa();
			infFacilidadPrueba = new InferenciaDifusa();
			infFLexibilidad = new InferenciaDifusa();
			infReusabilidad = new InferenciaDifusa();
			infInteroperabilidad = new InferenciaDifusa();
			infPortabilidad = new InferenciaDifusa();
			infOperacion = new InferenciaDifusa();
			infRevision = new InferenciaDifusa();
			infTransicion = new InferenciaDifusa();
			infCalidadSoftware = new InferenciaDifusa();
			
			//------------------------------------------------			
			infCalidadSoftware.AgregarEntrada(operacion_del_producto);
			infCalidadSoftware.AgregarEntrada(revision_del_producto);
			infCalidadSoftware.AgregarEntrada(transicion_del_producto);
			infCalidadSoftware.AgregarSalida(calidad_de_software);
			
			//------------------------------------------------	
			infFacilidadUso.AgregarEntrada(facilidad_de_operacion);
			infFacilidadUso.AgregarEntrada(facilidad_de_comunicacion);
			infFacilidadUso.AgregarEntrada(facilidad_de_aprendizaje);
			infFacilidadUso.AgregarEntrada(formacion);
			infFacilidadUso.AgregarSalida(facilidad_de_uso);
			
			//------------------------------------------------	
			infIntegridad.AgregarEntrada(control_de_acceso);
			infIntegridad.AgregarEntrada(facilidad_de_auditoria);
			infIntegridad.AgregarEntrada(seguridad);
			infIntegridad.AgregarSalida(integridad);
			
			//------------------------------------------------	
			infCorrecion.AgregarEntrada(completitud);
			infCorrecion.AgregarEntrada(consistencia);
			infCorrecion.AgregarEntrada(trazabilidad);
			infCorrecion.AgregarSalida(correcion);
			
			//------------------------------------------------	
			infFiabilidad.AgregarEntrada(precision);
			infFiabilidad.AgregarEntrada(consistencia);
			infFiabilidad.AgregarEntrada(tolerancia_a_fallas);
			infFiabilidad.AgregarEntrada(modularidad);
			infFiabilidad.AgregarEntrada(simplicidad);
			infFiabilidad.AgregarEntrada(exactitud);
			infFiabilidad.AgregarSalida(fiabilidad);
			
			//------------------------------------------------	
			infEficiencia.AgregarEntrada(eficiencia_de_ejecucion);
			infEficiencia.AgregarEntrada(eficiencia_de_almacenamiento);
			infEficiencia.AgregarSalida(eficiencia);
			
			//------------------------------------------------	
			infOperacion.AgregarEntrada(facilidad_de_uso);
			infOperacion.AgregarEntrada(integridad);
			infOperacion.AgregarEntrada(correcion);
			infOperacion.AgregarEntrada(fiabilidad);
			infOperacion.AgregarEntrada(eficiencia);
			infOperacion.AgregarSalida(operacion_del_producto);
			
			//------------------------------------------------	
			infRevision.AgregarEntrada(facilidad_de_mantenimiento);
			infRevision.AgregarEntrada(facilidad_de_prueba);
			infRevision.AgregarEntrada(flexibilidad);
			infRevision.AgregarSalida(revision_del_producto);
			
			//------------------------------------------------	
			infFacilidadMantenimiento.AgregarEntrada(modularidad);
			infFacilidadMantenimiento.AgregarEntrada(simplicidad);
			infFacilidadMantenimiento.AgregarEntrada(consistencia);
			infFacilidadMantenimiento.AgregarEntrada(consicion);
			infFacilidadMantenimiento.AgregarEntrada(auto_descripcion);
			infFacilidadMantenimiento.AgregarSalida(facilidad_de_mantenimiento);
			
			//------------------------------------------------	
			infFacilidadPrueba.AgregarEntrada(modularidad);
			infFacilidadPrueba.AgregarEntrada(simplicidad);
			infFacilidadPrueba.AgregarEntrada(auto_descripcion);
			infFacilidadPrueba.AgregarEntrada(instrumentacion);
			infFacilidadPrueba.AgregarSalida(facilidad_de_prueba);
			
			//------------------------------------------------	
			infFLexibilidad.AgregarEntrada(auto_descripcion);
			infFLexibilidad.AgregarEntrada(capacidad_de_expansion);
			infFLexibilidad.AgregarEntrada(generalidad);
			infFLexibilidad.AgregarEntrada(modularidad);
			infFLexibilidad.AgregarSalida(flexibilidad);
			
			//------------------------------------------------	
			infReusabilidad.AgregarEntrada(auto_descripcion);
			infReusabilidad.AgregarEntrada(generalidad);
			infReusabilidad.AgregarEntrada(modularidad);
			infReusabilidad.AgregarEntrada(independencia_de_software);
			infReusabilidad.AgregarEntrada(independencia_del_hardware);
			infReusabilidad.AgregarSalida(reusabilidad);
			
			//------------------------------------------------	
			infInteroperabilidad.AgregarEntrada(modularidad);
			infInteroperabilidad.AgregarEntrada(compatibilidad_de_comunicacion);
			infInteroperabilidad.AgregarEntrada(compatibilidad_de_datos);
			infInteroperabilidad.AgregarEntrada(estandarizacion_de_datos);
			infInteroperabilidad.AgregarSalida(interoperabilidad);
			
			//------------------------------------------------	
			infPortabilidad.AgregarEntrada(auto_descripcion);
			infPortabilidad.AgregarEntrada(modularidad);
			infPortabilidad.AgregarEntrada(independencia_de_software);
			infPortabilidad.AgregarEntrada(independencia_del_hardware);
			infPortabilidad.AgregarSalida(portabilidad);
			
			//------------------------------------------------	
			infTransicion.AgregarEntrada(reusabilidad);
			infTransicion.AgregarEntrada(interoperabilidad);
			infTransicion.AgregarEntrada(portabilidad);
			infTransicion.AgregarSalida(transicion_del_producto);
			
		}
	/**************************************************************************/
		void mnDefinirBaseReglasClick(object sender, EventArgs e){
			if(folderBrowserDialog.ShowDialog() == DialogResult.OK){
						pathReglas = folderBrowserDialog.SelectedPath ;
						mnCargarReglasClick(null,null);
			}
		}
	/**************************************************************************/
		void mnCargarReglasClick(object sender, EventArgs e)
		{
				
				Cursor = Cursors.WaitCursor;
			
				var sr = new System.IO.StreamReader(pathReglas+"\\reglas calidad de software.rgl");
			    String file = sr.ReadToEnd();
			    infCalidadSoftware.cargarReglas(file);
			    sr.Close();
			    
			    sr = new System.IO.StreamReader(pathReglas+"\\reglas operacion del producto.rgl");
			    file = sr.ReadToEnd();
			    infOperacion.cargarReglas(file);
			    sr.Close();
			    
				sr = new System.IO.StreamReader(pathReglas+"\\reglas revision del producto.rgl");
			    file = sr.ReadToEnd();
			    infRevision.cargarReglas(file);
			    sr.Close();
			    
			    sr = new System.IO.StreamReader(pathReglas+"\\reglas transicion del producto.rgl");
			    file = sr.ReadToEnd();
			    infTransicion.cargarReglas(file);
			    sr.Close();

				sr = new System.IO.StreamReader(pathReglas+"\\reglas facilidad de uso.rgl");
			    file = sr.ReadToEnd();
			    infFacilidadUso.cargarReglas(file);
			    sr.Close();
			    
			    sr = new System.IO.StreamReader(pathReglas+"\\reglas integridad.rgl");
			    file = sr.ReadToEnd();
			    infIntegridad.cargarReglas(file);
			    sr.Close();
			    
			    sr = new System.IO.StreamReader(pathReglas+"\\reglas correcion.rgl");
			    file = sr.ReadToEnd();
			    infCorrecion.cargarReglas(file);
			    sr.Close();
			    
			    sr = new System.IO.StreamReader(pathReglas+"\\reglas fiabilidad.rgl");
			    file = sr.ReadToEnd();
			    infFiabilidad.cargarReglas(file);
			    sr.Close();
			    
			    sr = new System.IO.StreamReader(pathReglas+"\\reglas eficiencia.rgl");
			    file = sr.ReadToEnd();
			    infEficiencia.cargarReglas(file);
			    sr.Close();
			    
			    sr = new System.IO.StreamReader(pathReglas+"\\reglas facilidad de mantenimiento.rgl");
			    file = sr.ReadToEnd();
			    infFacilidadMantenimiento.cargarReglas(file);
			    sr.Close();
			    
			    sr = new System.IO.StreamReader(pathReglas+"\\reglas facilidad de pruebas.rgl");
			    file = sr.ReadToEnd();
			    infFacilidadPrueba.cargarReglas(file);
			    sr.Close();
			    
			    sr = new System.IO.StreamReader(pathReglas+"\\reglas flexibilidad.rgl");
			    file = sr.ReadToEnd();
			    infFLexibilidad.cargarReglas(file);
			    sr.Close();
			    
			    sr = new System.IO.StreamReader(pathReglas+"\\reglas reusabilidad.rgl");
			    file = sr.ReadToEnd();
			    infReusabilidad.cargarReglas(file);
			    sr.Close();
			    
			    sr = new System.IO.StreamReader(pathReglas+"\\reglas interoperabilidad.rgl");
			    file = sr.ReadToEnd();
			    infInteroperabilidad.cargarReglas(file);
			    sr.Close();
			    
			    sr = new System.IO.StreamReader(pathReglas+"\\reglas portabilidad.rgl");
			    file = sr.ReadToEnd();
			    infPortabilidad.cargarReglas(file);
			    sr.Close();
			    
			    Cursor = Cursors.Default;
			    
			    MessageBox.Show("Base de Reglas cargada exitosamente","Reglas");
			   
		}
	/**************************************************************************/
		void inferir(object sender, EventArgs e){
			
			facilidad_de_uso.Restablecer();
			integridad.Restablecer();
			correcion.Restablecer();
			fiabilidad.Restablecer();
			eficiencia.Restablecer();
			operacion_del_producto.Restablecer();
			
			facilidad_de_mantenimiento.Restablecer();
			facilidad_de_prueba.Restablecer();
			flexibilidad.Restablecer();
			revision_del_producto.Restablecer();
			
			reusabilidad.Restablecer();
			interoperabilidad.Restablecer();
			portabilidad.Restablecer();
			transicion_del_producto.Restablecer();
			
			calidad_de_software.Restablecer();
			
			facilidad_de_operacion.Fuzzyficar(trkFacilidadOperacion.Value);
			formacion.Fuzzyficar(trkFormacion.Value);
			seguridad.Fuzzyficar(trkSeguridad.Value);
			facilidad_de_comunicacion.Fuzzyficar(trkFacilidadComunicacion.Value);
			facilidad_de_aprendizaje.Fuzzyficar(trkFacilidadAprendizaje.Value);
		 	facilidad_de_auditoria.Fuzzyficar(trkFacilidadAuditoria.Value);
		 	completitud.Fuzzyficar(trkCompletitud.Value);
		 	consistencia.Fuzzyficar(trkConsistencia.Value);
		 	trazabilidad.Fuzzyficar(trkTrazabilidad.Value);
		 	precision.Fuzzyficar(trkPrecision.Value);
		 	tolerancia_a_fallas.Fuzzyficar(trkToleranciaFallos.Value);
		 	exactitud.Fuzzyficar(trkExactitud.Value);
		 	auto_descripcion.Fuzzyficar(trkAutoDescripcion.Value);
		 	instrumentacion.Fuzzyficar(trkInstrumentacion.Value);
		 	modularidad.Fuzzyficar(trkModularidad.Value);
		 	simplicidad.Fuzzyficar(trkSimplicidad.Value);
		 	consicion.Fuzzyficar(trkConcision.Value);
		 	capacidad_de_expansion.Fuzzyficar(trkCapacidadExpansion.Value);
		 	generalidad.Fuzzyficar(trkGeneralidad.Value);
		 	compatibilidad_de_comunicacion.Fuzzyficar(trkCompatibilidadComunicacion.Value);
		 	compatibilidad_de_datos.Fuzzyficar(trkCompatibilidadDatos.Value);
		 	estandarizacion_de_datos.Fuzzyficar(trkEstandarizacionDatos.Value);
		 	eficiencia_de_ejecucion.Fuzzyficar(trkEficienciaEjecucion.Value);
		 	eficiencia_de_almacenamiento.Fuzzyficar(trkEficienciaAlmacenamiento.Value);	

		 	if(rbControlSi.Checked)
		 		control_de_acceso.Fuzzyficar(10);
			else
				control_de_acceso.Fuzzyficar(0);
			
			if(rbIndSoftwareSi.Checked)
			 	independencia_de_software.Fuzzyficar(10);
			else
				independencia_de_software.Fuzzyficar(0);
			
			if(rbIndHardwareSi.Checked)
			 	independencia_del_hardware.Fuzzyficar(10);
			else
				independencia_del_hardware.Fuzzyficar(0);
			
			infFacilidadUso.Inferir();
			infIntegridad.Inferir();
			infCorrecion.Inferir();
			infFiabilidad.Inferir();
			infEficiencia.Inferir();
			
			infFacilidadMantenimiento.Inferir();
			infFacilidadPrueba.Inferir();
			infFLexibilidad.Inferir();
			
			infReusabilidad.Inferir();
			infInteroperabilidad.Inferir();
			infPortabilidad.Inferir();
			
			
			var facUso =  facilidad_de_uso.Defuzzyficar(Metodo.CENTROIDE);
			var integ = integridad.Defuzzyficar(Metodo.CENTROIDE);
			var correc = correcion.Defuzzyficar(Metodo.CENTROIDE);
			var fiabli = fiabilidad.Defuzzyficar(Metodo.CENTROIDE);
			var efici = eficiencia.Defuzzyficar(Metodo.CENTROIDE);
			prgFacilidadUso.Value = (int) facUso *100;
			prgIntegridad.Value = (int) integ *100;
			prgCorreccion.Value = (int) correc *100;
			prgFiabilidad.Value = (int) fiabli *100;
			prgEficiencia.Value = (int) efici *100;
			facilidad_de_uso.Fuzzyficar(facUso);
			integridad.Fuzzyficar(integ);
			correcion.Fuzzyficar(correc);
			fiabilidad.Fuzzyficar(fiabli);
			eficiencia.Fuzzyficar(efici);
			
			var facMan = facilidad_de_mantenimiento.Defuzzyficar(Metodo.CENTROIDE);
			var facPru = facilidad_de_prueba.Defuzzyficar(Metodo.CENTROIDE);
			var flexi = flexibilidad.Defuzzyficar(Metodo.CENTROIDE);
			prgFacilidadMantenimiento.Value = (int) facMan *100;
			prgFacilidadPrueba.Value = (int) facPru *100;
			prgFlexibilidad.Value = (int) flexi *100;
			facilidad_de_mantenimiento.Fuzzyficar(facMan);
			facilidad_de_prueba.Fuzzyficar(facPru);
			flexibilidad.Fuzzyficar(flexi);
			
			var reus = reusabilidad.Defuzzyficar(Metodo.CENTROIDE);
			var inter = interoperabilidad.Defuzzyficar(Metodo.CENTROIDE);
			var porta = portabilidad.Defuzzyficar(Metodo.CENTROIDE);
			prgReusabilidad.Value = (int) reus *100;
			prgInteroperabilidad.Value = (int) inter *100;
			prgPortabilidad.Value = (int) porta *100;
			reusabilidad.Fuzzyficar(reus);
			interoperabilidad.Fuzzyficar(inter);
			portabilidad.Fuzzyficar(porta);
			
			infOperacion.Inferir();
			infRevision.Inferir();
			infTransicion.Inferir();
			
			var oper = operacion_del_producto.Defuzzyficar(Metodo.CENTROIDE);
			var revi = revision_del_producto.Defuzzyficar(Metodo.CENTROIDE);
			var transi = transicion_del_producto.Defuzzyficar(Metodo.CENTROIDE);
			prgFacilidadMantenimiento.Value = (int) oper *100;
			prgFacilidadPrueba.Value = (int) revi *100;
			prgFlexibilidad.Value = (int) transi *100;
			operacion_del_producto.Fuzzyficar(oper);
			revision_del_producto.Fuzzyficar(revi);
			transicion_del_producto.Fuzzyficar(transi);
			
			infCalidadSoftware.Inferir();
			
			gauCalidad.Value = (int) calidad_de_software.Defuzzyficar(Metodo.CENTROIDE) * 100 ;
			
			
		}
	/**************************************************************************/


	}
}
