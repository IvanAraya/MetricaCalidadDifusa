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
		public FrmMain()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			

		}
		
		public void inicializarVariables()
		{
			
			
			//----------------------------------------------------------------
			
			var facilidad_de_operacion = new VariableDifusa("facilidad_de_operacion", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("muy_mala", 0, 2, 4),
			                                   	new FuncionTriangular("mala", 2, 4, 6),
			                                   	new FuncionTriangular("promedio", 4, 6, 8),
			                                   	new FuncionTriangular("buena", 6, 8, 10),
			                                   	new FuncionSaturacion("excelente", 8, 10, 10)
			                                   });	
			var formacion = new VariableDifusa("formacion", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("muy_mala", 0, 2, 4),
			                                   	new FuncionTriangular("mala", 2, 4, 6),
			                                   	new FuncionTriangular("promedio", 4, 6, 8),
			                                   	new FuncionTriangular("buena", 6, 8, 10),
			                                   	new FuncionSaturacion("excelente", 8, 10, 10)
			                                   });
			var seguridad = new VariableDifusa("seguridad", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("muy_mala", 0, 2, 4),
			                                   	new FuncionTriangular("mala", 2, 4, 6),
			                                   	new FuncionTriangular("promedio", 4, 6, 8),
			                                   	new FuncionTriangular("buena", 6, 8, 10),
			                                   	new FuncionSaturacion("excelente", 8, 10, 10)
			                                   });
			//----------------------------------------------------------------		
			var facilidad_de_comunicacion = new VariableDifusa("facilidad_de_comunicacion", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("muy_dificil", 0, 2, 4),
			                                   	new FuncionTriangular("dificil", 2, 4, 6),
			                                   	new FuncionTriangular("normal", 4, 6, 8),
			                                   	new FuncionTriangular("facil", 6, 8, 10),
			                                   	new FuncionSaturacion("muy_facil", 8, 10, 10)
			                                   });
			var facilidad_de_aprendizaje = new VariableDifusa("facilidad_de_aprendizaje", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("muy_dificil", 0, 2, 4),
			                                   	new FuncionTriangular("dificil", 2, 4, 6),
			                                   	new FuncionTriangular("normal", 4, 6, 8),
			                                   	new FuncionTriangular("facil", 6, 8, 10),
			                                   	new FuncionSaturacion("muy_facil", 8, 10, 10)
			                                   });			
			var facilidad_de_auditoria = new VariableDifusa("facilidad_de_auditoria", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("muy_dificil", 0, 2, 4),
			                                   	new FuncionTriangular("dificil", 2, 4, 6),
			                                   	new FuncionTriangular("normal", 4, 6, 8),
			                                   	new FuncionTriangular("facil", 6, 8, 10),
			                                   	new FuncionSaturacion("muy_facil", 8, 10, 10)
			                                   });
			//----------------------------------------------------------------	
			var completitud = new VariableDifusa("completitud", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("nunca", 0, 2, 4),
			                                   	new FuncionTriangular("pocas_veces", 2, 4, 6),
			                                   	new FuncionTriangular("algunas_veces", 4, 6, 8),
			                                   	new FuncionTriangular("casi_siempre", 6, 8, 10),
			                                   	new FuncionSaturacion("siempre", 8, 10, 10)
			                                   });
			var consistencia = new VariableDifusa("consistencia", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("nunca", 0, 2, 4),
			                                   	new FuncionTriangular("pocas_veces", 2, 4, 6),
			                                   	new FuncionTriangular("algunas_veces", 4, 6, 8),
			                                   	new FuncionTriangular("casi_siempre", 6, 8, 10),
			                                   	new FuncionSaturacion("siempre", 8, 10, 10)
			                                   });
			var trazabilidad = new VariableDifusa("trazabilidad", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("nunca", 0, 2, 4),
			                                   	new FuncionTriangular("pocas_veces", 2, 4, 6),
			                                   	new FuncionTriangular("algunas_veces", 4, 6, 8),
			                                   	new FuncionTriangular("casi_siempre", 6, 8, 10),
			                                   	new FuncionSaturacion("siempre", 8, 10, 10)
			                                   });
			var precision = new VariableDifusa("precision", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("nunca", 0, 2, 4),
			                                   	new FuncionTriangular("pocas_veces", 2, 4, 6),
			                                   	new FuncionTriangular("algunas_veces", 4, 6, 8),
			                                   	new FuncionTriangular("casi_siempre", 6, 8, 10),
			                                   	new FuncionSaturacion("siempre", 8, 10, 10)
			                                   });
			var tolerancia_a_fallas = new VariableDifusa("tolerancia_a_fallas", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("nunca", 0, 2, 4),
			                                   	new FuncionTriangular("pocas_veces", 2, 4, 6),
			                                   	new FuncionTriangular("algunas_veces", 4, 6, 8),
			                                   	new FuncionTriangular("casi_siempre", 6, 8, 10),
			                                   	new FuncionSaturacion("siempre", 8, 10, 10)
			                                   });
			var exactitud = new VariableDifusa("exactitud", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("nunca", 0, 2, 4),
			                                   	new FuncionTriangular("pocas_veces", 2, 4, 6),
			                                   	new FuncionTriangular("algunas_veces", 4, 6, 8),
			                                   	new FuncionTriangular("casi_siempre", 6, 8, 10),
			                                   	new FuncionSaturacion("siempre", 8, 10, 10)
			                                   });
			var auto_descripcion = new VariableDifusa("auto_descripcion", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("nunca", 0, 2, 4),
			                                   	new FuncionTriangular("pocas_veces", 2, 4, 6),
			                                   	new FuncionTriangular("algunas_veces", 4, 6, 8),
			                                   	new FuncionTriangular("casi_siempre", 6, 8, 10),
			                                   	new FuncionSaturacion("siempre", 8, 10, 10)
			                                   });
			var instrumentacion = new VariableDifusa("instrumentacion", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("nunca", 0, 2, 4),
			                                   	new FuncionTriangular("pocas_veces", 2, 4, 6),
			                                   	new FuncionTriangular("algunas_veces", 4, 6, 8),
			                                   	new FuncionTriangular("casi_siempre", 6, 8, 10),
			                                   	new FuncionSaturacion("siempre", 8, 10, 10)
			                                   });
			//----------------------------------------------------------------	
			var modularidad = new VariableDifusa("modularidad", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("no", 0, 2, 4),
			                                   	new FuncionTriangular("poco", 2, 4, 6),
			                                   	new FuncionTriangular("medianamente", 4, 6, 8),
			                                   	new FuncionTriangular("casi_todo", 6, 8, 10),
			                                   	new FuncionSaturacion("completamente", 8, 10, 10)
			                                   });
			var simplicidad = new VariableDifusa("simplicidad", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("no", 0, 2, 4),
			                                   	new FuncionTriangular("poco", 2, 4, 6),
			                                   	new FuncionTriangular("medianamente", 4, 6, 8),
			                                   	new FuncionTriangular("casi_todo", 6, 8, 10),
			                                   	new FuncionSaturacion("completamente", 8, 10, 10)
			                                   });
			var consicion = new VariableDifusa("consicion", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("no", 0, 2, 4),
			                                   	new FuncionTriangular("poco", 2, 4, 6),
			                                   	new FuncionTriangular("medianamente", 4, 6, 8),
			                                   	new FuncionTriangular("casi_todo", 6, 8, 10),
			                                   	new FuncionSaturacion("completamente", 8, 10, 10)
			                                   });
			var capacidad_de_expansion = new VariableDifusa("capacidad_de_expansion", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("no", 0, 2, 4),
			                                   	new FuncionTriangular("poco", 2, 4, 6),
			                                   	new FuncionTriangular("medianamente", 4, 6, 8),
			                                   	new FuncionTriangular("casi_todo", 6, 8, 10),
			                                   	new FuncionSaturacion("completamente", 8, 10, 10)
			                                   });
			var generalidad = new VariableDifusa("generalidad", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("no", 0, 2, 4),
			                                   	new FuncionTriangular("poco", 2, 4, 6),
			                                   	new FuncionTriangular("medianamente", 4, 6, 8),
			                                   	new FuncionTriangular("casi_todo", 6, 8, 10),
			                                   	new FuncionSaturacion("completamente", 8, 10, 10)
			                                   });
			var compatibilidad_de_comunicacion = new VariableDifusa("compatibilidad_de_comunicacion", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("no", 0, 2, 4),
			                                   	new FuncionTriangular("poco", 2, 4, 6),
			                                   	new FuncionTriangular("medianamente", 4, 6, 8),
			                                   	new FuncionTriangular("casi_todo", 6, 8, 10),
			                                   	new FuncionSaturacion("completamente", 8, 10, 10)
			                                   });
			var compatibilidad_de_datos = new VariableDifusa("compatibilidad_de_datos", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("no", 0, 2, 4),
			                                   	new FuncionTriangular("poco", 2, 4, 6),
			                                   	new FuncionTriangular("medianamente", 4, 6, 8),
			                                   	new FuncionTriangular("casi_todo", 6, 8, 10),
			                                   	new FuncionSaturacion("completamente", 8, 10, 10)
			                                   });
			var estandarizacion_de_datos = new VariableDifusa("estandarizacion_de_datos", 0, 10, new List<FuncionPertenencia> {
			                                   	new FuncionHombro("no", 0, 2, 4),
			                                   	new FuncionTriangular("poco", 2, 4, 6),
			                                   	new FuncionTriangular("medianamente", 4, 6, 8),
			                                   	new FuncionTriangular("casi_todo", 6, 8, 10),
			                                   	new FuncionSaturacion("completamente", 8, 10, 10)
			                                   });
			
		}

	}
}
