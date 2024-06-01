using System;
using System.Windows.Forms;
using SharpGL;

namespace OpenGL_lesson_CSharp
{
    public partial class SharpGLForm : Form
    {
        float rotation = 0.0f;

        public SharpGLForm()
        {
            InitializeComponent();
        }

        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs e)
        {
            // используем OpenGL объект
            OpenGL gl = openGLControl.OpenGL;

            // очистка буферов цвета и глубины
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            // единичная матрица для последующих преобразований
            // заменяет текущую матрицу на единичную
            gl.LoadIdentity();

            // оси вращения (x, -y-, z)
            gl.Rotate(rotation, 0.0f, 1.0f, 0.0f);

            // крыша (едет) центральной башни
            gl.Begin(OpenGL.GL_TRIANGLES);
            
            gl.Color(0.0f, 0.2f, 1f);    // цвет плоскости
            gl.Vertex(0.0f, 7f, 0.0f);
            gl.Vertex(0.5f, 5f, -0.5f);
            gl.Vertex(0.5f, 5f, 0.5f);

            gl.Color(0.0f, 0.3f, 1f);
            gl.Vertex(0.0f, 7f, 0.0f);
            gl.Vertex(-0.5f, 5f, -0.5f);
            gl.Vertex(-0.5f, 5f, 0.5f);
            
            gl.Color(0.0f, 0.4f, 1f);
            gl.Vertex(0.0f, 7f, 0.0f);
            gl.Vertex(0.5f, 5f, -0.5f);
            gl.Vertex(-0.5f, 5f, -0.5f);

            gl.Color(0.0f, 0.1f, 1f);
            gl.Vertex(0.0f, 7f, 0.0f);
            gl.Vertex(-0.5f, 5f, 0.5f);
            gl.Vertex(0.5f, 5f, 0.5f);
          
            gl.End();
            
            //центральная башня
            // 1 стена (передняя)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9f, 0f, 1f);
            gl.Vertex(0.5f, 5f, -0.5f);
            gl.Vertex(0.5f, 0f, -0.5f);
            gl.Vertex(-0.5f, 0f, -0.5f);
            gl.Vertex(-0.5f, 5f, -0.5f);
            
            gl.End();
            
            // 2 стена (правая)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9f, 0f, 0.8f);
            gl.Vertex(0.5f, 0f, -0.5f);
            gl.Vertex(0.5f, 0f, 0.5f);
            gl.Vertex(0.5f, 5f, 0.5f);
            gl.Vertex(0.5f, 5f, -0.5f);
            gl.End();
            
            // 3 стена (задняя)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9f, 0f, 0.7f);
            gl.Vertex(0.5f, 0f, 0.5f);
            gl.Vertex(-0.5f, 0f, 0.5f);
            gl.Vertex(-0.5f, 5f, 0.5f);
            gl.Vertex(0.5f, 5f, 0.5f);
            gl.End();

            // 4 стена (левая) (не ломается)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9f, 0f, 0.9f);
            gl.Vertex(-0.5f, 0f, -0.5f);
            gl.Vertex(-0.5f, 0f, 0.5f);
            gl.Vertex(-0.5f, 5f, 0.5f);
            gl.Vertex(-0.5f, 5f, -0.5f);
            gl.End();

            //--------------------------------------------------------------------
            // крыша (едет) левой башни
            gl.Begin(OpenGL.GL_TRIANGLES);

            gl.Color(0.0f, 0.2f, 1f); 
            gl.Vertex(0f, 5f, 1.5f);
            gl.Vertex(0.5f, 4f, 1f);
            gl.Vertex(0.5f, 4f, 2f);

            gl.Color(0.0f, 0.3f, 1f);
            gl.Vertex(0f, 5f, 1.5f);
            gl.Vertex(-0.5f, 4f, 1f);
            gl.Vertex(-0.5f, 4f, 2f);

            gl.Color(0.0f, 0.4f, 1f);
            gl.Vertex(0f, 5f, 1.5f);
            gl.Vertex(0.5f, 4f, 1f);
            gl.Vertex(-0.5f, 4f, 1f);

            gl.Color(0.0f, 0.1f, 1f);
            gl.Vertex(0f, 5f, 1.5f);
            gl.Vertex(-0.5f, 4f, 2f);
            gl.Vertex(0.5f, 4f, 2f);

            gl.End();

            //левая башня
            // 1 стена (передняя)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9f, 0f, 1f);
            gl.Vertex(0.5f, 4f, 1f);
            gl.Vertex(0.5f, 0f, 1f);
            gl.Vertex(-0.5f, 0f, 1f);
            gl.Vertex(-0.5f, 4f, 1f);

            gl.End();

            // 2 стена (правая)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9f, 0f, 0.8f);
            gl.Vertex(0.5f, 0f, 1f);
            gl.Vertex(0.5f, 0f, 2f);
            gl.Vertex(0.5f, 4f, 2f);
            gl.Vertex(0.5f, 4f, 1f);
            gl.End();

            // 3 стена (задняя)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9f, 0f, 0.7f);
            gl.Vertex(0.5f, 0f, 2f);
            gl.Vertex(-0.5f, 0f, 2f);
            gl.Vertex(-0.5f, 4f, 2f);
            gl.Vertex(0.5f, 4f, 2f);
            gl.End();

            // 4 стена (левая) (не ломается)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9f, 0f, 0.9f);
            gl.Vertex(-0.5f, 0f, 1f);
            gl.Vertex(-0.5f, 0f, 2f);
            gl.Vertex(-0.5f, 4f, 2f);
            gl.Vertex(-0.5f, 4f, 1f);
            gl.End();


            //--------------------------------------------------------------------
            // крыша (едет) правой башни
            gl.Begin(OpenGL.GL_TRIANGLES);

            gl.Color(0.0f, 0.2f, 1f); 
            gl.Vertex(0.0f, 5f, -1.5f);
            gl.Vertex(0.5f, 4f, -2f);
            gl.Vertex(0.5f, 4f, -1f);

            gl.Color(0.0f, 0.3f, 1f);
            gl.Vertex(0.0f, 5f, -1.5f);
            gl.Vertex(-0.5f, 4f, -1f);
            gl.Vertex(-0.5f, 4f, -2f);

            gl.Color(0.0f, 0.4f, 1f);
            gl.Vertex(0.0f, 5f, -1.5f);
            gl.Vertex(0.5f, 4f, -1f);
            gl.Vertex(-0.5f, 4f, -1f);

            gl.Color(0.0f, 0.1f, 1f);
            gl.Vertex(0.0f, 5f, -1.5f);
            gl.Vertex(-0.5f, 4f, -2f);
            gl.Vertex(0.5f, 4f, -2f);

            gl.End();

            //правая башня
            // 1 стена (передняя)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9f, 0f, 1f);
            gl.Vertex(0.5f, 4f, -1f);
            gl.Vertex(0.5f, 0f, -1f);
            gl.Vertex(-0.5f, 0f, -1f);
            gl.Vertex(-0.5f, 4f, -1f);

            gl.End();

            // 2 стена (правая)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9f, 0f, 0.8f);
            gl.Vertex(0.5f, 0f, -1f);
            gl.Vertex(0.5f, 0f, -2f);
            gl.Vertex(0.5f, 4f, -2f);
            gl.Vertex(0.5f, 4f, -1f);
            gl.End();

            // 3 стена (задняя)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9f, 0f, 0.7f);
            gl.Vertex(0.5f, 0f, -2f);
            gl.Vertex(-0.5f, 0f, -2f);
            gl.Vertex(-0.5f, 4f, -2f);
            gl.Vertex(0.5f, 4f, -2f);
            gl.End();

            // 4 стена (левая) (не ломается)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9f, 0f, 0.9f);
            gl.Vertex(-0.5f, 0f, -1f);
            gl.Vertex(-0.5f, 0f, -2f);
            gl.Vertex(-0.5f, 4f, -2f);
            gl.Vertex(-0.5f, 4f, -1f);
            gl.End();

            //--------------------------------------------------------------------
            // пространство между башнями
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9f, 0f, 0.8f);      // следить за цветом, чтобы не было "мерцания"! (цвет, как у правой стены башни)
            gl.Vertex(0.5f, 0f, -2f);
            gl.Vertex(0.5f, 0f, 2f);
            gl.Vertex(0.5f, 3f, 2f);
            gl.Vertex(0.5f, 3f, -2f);
            gl.End();
            
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9f, 0f, 0.9f);      // следить за цветом, чтобы не было "мерцания"! (цвет, как у левой стены башни)
            gl.Vertex(-0.5f, 3f, -2f);
            gl.Vertex(0.5f, 3f, -2f);
            gl.Vertex(0.5f, 3f, 2f);
            gl.Vertex(-0.5f, 3f, 2f);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9f, 0f, 0.9f);      // следить за цветом, чтобы не было "мерцания"! (цвет, как у левой стены башни)
            gl.Vertex(-0.501f, 0f, -2f);
            gl.Vertex(-0.501f, 0f, 2f);
            gl.Vertex(-0.501f, 3f, 2f);
            gl.Vertex(-0.501f, 3f, -2f);
            gl.End();

            //--------------------------------------------------------------------
            // дверь (передняя стена)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5f, 0.3f, 0f);
            gl.Vertex(0.51f, 0f, -0.5f);
            gl.Vertex(0.51f, 0f, 0.5f);
            gl.Vertex(0.51f, 1.75f, 0.5f);
            gl.Vertex(0.51f, 1.75f, -0.5f);
            gl.End();

            // окно верхнее (передняя стена)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.1f, 0.5f, 1f);
            gl.Vertex(0.51f, 3.5f, -0.25f);
            gl.Vertex(0.51f, 3.5f, 0.25f);
            gl.Vertex(0.51f, 4.3f, 0.25f);
            gl.Vertex(0.51f, 4.3f, -0.25f);
            gl.End();

            // окно слева (передняя стена)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.1f, 0.5f, 1f);
            gl.Vertex(0.51f, 2.5f, 1.25f);
            gl.Vertex(0.51f, 2.5f, 1.75f);
            gl.Vertex(0.51f, 3.3f, 1.75f);
            gl.Vertex(0.51f, 3.3f, 1.25f);
            gl.End();

            // окно справа (передняя стена)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.1f, 0.5f, 1f);
            gl.Vertex(0.51f, 2.5f, -1.75f);
            gl.Vertex(0.51f, 2.5f, -1.25f);
            gl.Vertex(0.51f, 3.3f, -1.25f);
            gl.Vertex(0.51f, 3.3f, -1.75f);
            gl.End();

            // окно верхнее (задняя стена)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.1f, 0.5f, 1f);
            gl.Vertex(-0.51f, 3.5f, -0.25f);
            gl.Vertex(-0.51f, 3.5f, 0.25f);
            gl.Vertex(-0.51f, 4.3f, 0.25f);
            gl.Vertex(-0.51f, 4.3f, -0.25f);
            gl.End();

            // окно1 слева (задняя стена)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.1f, 0.5f, 1f);
            gl.Vertex(-0.51f, 2.5f, 1.25f);
            gl.Vertex(-0.51f, 2.5f, 1.75f);
            gl.Vertex(-0.51f, 3.3f, 1.75f);
            gl.Vertex(-0.51f, 3.3f, 1.25f);
            gl.End();

            // окно1 справа (задняя стена)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.1f, 0.5f, 1f);
            gl.Vertex(-0.51f, 2.5f, -1.75f);
            gl.Vertex(-0.51f, 2.5f, -1.25f);
            gl.Vertex(-0.51f, 3.3f, -1.25f);
            gl.Vertex(-0.51f, 3.3f, -1.75f);
            gl.End();

            // окно большое (задняя стена)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.1f, 0.5f, 1f);
            gl.Vertex(-0.51f, 0.5f, -0.25f);
            gl.Vertex(-0.51f, 0.5f, 0.25f);
            gl.Vertex(-0.51f, 1.75f, 0.25f);
            gl.Vertex(-0.51f, 1.75f, -0.25f);
            gl.End();

            // земля            
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0f, 0.3f, 0f);
            gl.Vertex(-20f, 0f, -20f);
            gl.Vertex(20f, 0f, -20f);
            gl.Vertex(20f, 0f, 20f);
            gl.Vertex(-20f, 0f, 20f);
            gl.End();

            // озеро
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.2f, 1f);
            gl.Vertex(-3f, 0.1f, -3.2f);
            gl.Vertex(-3.6f, 0.1f, -2.4f);
            gl.Vertex(-5f, 0.1f, -2.4f);
            gl.Vertex(-5.6f, 0.1f, -3f);
            gl.Vertex(-6.2f, 0.1f, -4.8f);
            gl.Vertex(-6.4f, 0.1f, -6.2f);
            gl.Vertex(-6.2f, 0.1f, -7.2f);
            gl.Vertex(-5f, 0.1f, -7.4f);
            gl.Vertex(-3.8f, 0.1f, -7f);
            gl.Vertex(-2.8f, 0.1f, -5f);
            gl.End();

            rotation += 1.5f;
        }
       
        // функция для задания значений по умолчанию
        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
           // используем OpenGL объект
            OpenGL gl = openGLControl.OpenGL;

            // цвет неба (голубой)
            gl.ClearColor(0.1f, 0.7f, 1f, 0);
        }

        // функция для преобразования изображения 
        // объёмный вид + перспектива
        private void openGLControl_Resized(object sender, EventArgs e)
        {
            // используем OpenGL объект
            OpenGL gl = openGLControl.OpenGL;

            // выбираем, какую матрицу изменить (режим работы - матрица проекции)
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            // единичная матрица для последующих преобразований
            // заменяет текущую матрицу на единичную
            gl.LoadIdentity();

            // функция перспективного проецирования
            //gl.Frustum(-1, 1, -1, 1, 1.5, 15);
            // функция параллельного проецирования
            //gl.Ortho(-5, 5, -5, 5, 1.5, 15);
            // преобразование
            gl.Perspective(60.0f, (double)Width / (double)Height, 0.01, 100.0);

            // функция установки камеры
            gl.LookAt(5, 6, -7,     // позиция камеры
                      0, 3, 0,     // направление камеры
                      0, 2, 0);    // верх камеры


            // выбираем, какую матрицу изменить (режим работы - модельно-видовая матрица)
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }
    }
}