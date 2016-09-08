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
		VariableDifusa Control_de_acceso;
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
		
	/***************************************************************************/
		public FrmMain()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			

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
			Control_de_acceso = new VariableDifusa("eficiencia_de_ejecucion", 0, 10, new List<FuncionPertenencia> {
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


	}
}
