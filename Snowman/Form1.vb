Public Class Form1
 Private snow As New List(Of PointF)
 Private r As New Random
 Private ground As Integer = 5

 Private Sub pboxPlatno_Paint(sender As Object, e As PaintEventArgs) Handles pboxPlatno.Paint
  Dim snowmanColor, groundColor, lineColor, backColor As Color
  Dim lineThickness As Integer = 3
  backColor = pboxSkyColor.BackColor
  groundColor = pboxSnowColor.BackColor
  snowmanColor = pboxSnowColor.BackColor
  e.Graphics.FillRectangle(New SolidBrush(backColor), pboxPlatno.ClientRectangle)
  DrawSnowman(e.Graphics, snowmanColor, lineColor, lineThickness, tbarSize.Value, 5)
  DrawGround(e.Graphics, groundColor, lineColor, lineThickness, ground)

  Dim i As Integer = 0
  Dim size As Single
  Do Until i >= snow.Count
   size = r.NextDouble * 2 + 4
   If pboxPlatno.ClientRectangle.Contains(Point.Round(snow(i))) Then
    e.Graphics.FillEllipse(New SolidBrush(snowmanColor), snow(i).X, snow(i).Y, size, size)
   End If
   i += 1
  Loop
 End Sub

 Private Sub DrawSnowman(g As Graphics, snowmanColor As Color, lineColor As Color, line As Integer, heightPercent As Integer, groundPercent As Integer)
  Dim heightPoints As Integer = Int(pboxPlatno.Height * (heightPercent * 0.01))
  Dim groundLevel As Integer = Int(pboxPlatno.Height - pboxPlatno.Height * (groundPercent * 0.01))
  Dim p As New Pen(Color.Black, line)
  Dim b As New SolidBrush(snowmanColor)
  Dim middle As Integer = pboxPlatno.Width * tbarPosition.Value * 0.01
  Dim bottomSphere As Integer = CInt(heightPoints * 0.45)
  Dim midSphere As Integer = CInt(heightPoints * 0.33)
  Dim headSphere As Integer = heightPoints - bottomSphere - midSphere
  Dim handSphere As Integer = CInt(heightPoints * 0.15)
  Dim coal As Integer = CInt(midSphere \ 8)
  Dim tooth As Integer = coal \ 2
  groundLevel = groundLevel + CInt(bottomSphere * 0.05)
  Dim bottomSphereTop As Integer = groundLevel - bottomSphere
  Dim midSphereTop As Integer = bottomSphereTop - CInt(midSphere * 0.8)
  Dim headSphereTop As Integer = midSphereTop - CInt(headSphere * 0.8)
  Dim handSphereTop As Integer = midSphereTop + handSphere \ 3
  Dim handDistance As Integer = midSphere \ 2 - CInt(handSphere * 0.2)
  g.FillEllipse(b, middle - bottomSphere \ 2, bottomSphereTop, bottomSphere, bottomSphere)
  g.DrawEllipse(p, middle - bottomSphere \ 2, bottomSphereTop, bottomSphere, bottomSphere)
  g.FillEllipse(b, middle - handDistance - handSphere, handSphereTop, handSphere, handSphere)
  g.DrawEllipse(p, middle - handDistance - handSphere, handSphereTop, handSphere, handSphere)
  g.FillEllipse(b, middle - midSphere \ 2, midSphereTop, midSphere, midSphere)
  g.DrawEllipse(p, middle - midSphere \ 2, midSphereTop, midSphere, midSphere)
  g.FillEllipse(b, middle - headSphere \ 2, headSphereTop, headSphere, headSphere)
  g.DrawEllipse(p, middle - headSphere \ 2, headSphereTop, headSphere, headSphere)
  g.FillEllipse(b, middle + handDistance, handSphereTop, handSphere, handSphere)
  g.DrawEllipse(p, middle + handDistance, handSphereTop, handSphere, handSphere)
  g.FillEllipse(Brushes.Black, middle - CInt(1.4 * coal), groundLevel - 5 * coal, coal, coal)
  g.FillEllipse(Brushes.Black, middle - CInt(1.6 * coal), groundLevel - CInt(7 * coal), coal, coal)
  g.FillEllipse(Brushes.Black, middle - CInt(1.2 * coal), groundLevel - 9 * coal, coal, coal)
  g.FillEllipse(Brushes.Black, middle - CInt(1.2 * coal), bottomSphereTop - CInt(1 * coal), coal, coal)
  g.FillEllipse(Brushes.Black, middle - CInt(1.4 * coal), bottomSphereTop - CInt(3 * coal), coal, coal)
  g.FillEllipse(Brushes.Black, middle - CInt(0.9 * coal), bottomSphereTop - CInt(5 * coal), coal, coal)
  g.FillEllipse(Brushes.Black, middle - CInt(1.7 * coal), midSphereTop - CInt(2.85 * coal), coal, coal)
  g.FillEllipse(Brushes.Black, middle + CInt(0.3 * coal), midSphereTop - CInt(2.8 * coal), coal, coal)
  g.FillEllipse(Brushes.Black, middle + CInt(tooth), midSphereTop - CInt(1.5 * tooth), tooth, tooth)
  g.FillEllipse(Brushes.Black, middle + CInt(0 * tooth), midSphereTop - CInt(1.6 * tooth), tooth, tooth)
  g.FillEllipse(Brushes.Black, middle - CInt(1.0 * tooth), midSphereTop - CInt(1.7 * tooth), tooth, tooth)
  g.FillEllipse(Brushes.Black, middle - CInt(2.0 * tooth), midSphereTop - CInt(1.8 * tooth), tooth, tooth)
  g.FillEllipse(Brushes.Black, middle - CInt(3.0 * tooth), midSphereTop - CInt(1.9 * tooth), tooth, tooth)
 End Sub

 Private Sub DrawGround(g As Graphics, groundColor As Color, lineColor As Color, line As Integer, heightPercent As Integer)
  Dim heightPoints As Integer = Int(pboxPlatno.Height * (heightPercent * 0.01))
  Dim p As New Pen(Color.Black, line)
  g.FillRectangle(New SolidBrush(groundColor), 0, pboxPlatno.Height - heightPoints, pboxPlatno.Width, heightPoints)
  g.DrawLine(p, 0, pboxPlatno.Height - heightPoints, pboxPlatno.Width, pboxPlatno.Height - heightPoints)
 End Sub

 Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
  tbarPosition.Width = pboxPlatno.Width
  tbarSize.Height = pboxPlatno.Height - 150
  tbarSnow.Height = pboxPlatno.Height - 150
  pboxPlatno.Refresh()
 End Sub

 Private Sub pboxSkyColor_Click(sender As Object, e As EventArgs) Handles pboxSkyColor.Click
  ColorDialog1.Color = pboxSkyColor.BackColor
  ColorDialog1.ShowDialog()
  pboxSkyColor.BackColor = ColorDialog1.Color
  pboxPlatno.Refresh()
 End Sub

 Private Sub pboxSnowColor_Click(sender As Object, e As EventArgs) Handles pboxSnowColor.Click
  ColorDialog1.Color = pboxSnowColor.BackColor
  ColorDialog1.ShowDialog()
  pboxSnowColor.BackColor = ColorDialog1.Color
  pboxPlatno.Refresh()
 End Sub

 Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
  tbarSize.Value = 75
  tbarPosition.Value = 50
 End Sub

 Private Sub tbarSize_Scroll(sender As Object, e As EventArgs) Handles tbarSize.Scroll, tbarPosition.Scroll
  pboxPlatno.Refresh()
 End Sub

 Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick



  Me.Text = $"Sněhulák - {snow.Count} vloček"
  For j = 1 To Int(tbarSnow.Value * 0.8)
   snow.Add(New PointF(r.Next(-pboxPlatno.Width, 2 * pboxPlatno.Width), 0))
  Next
  Dim i As Integer = 0
  Do Until i >= snow.Count
   If snow(i).Y > Int(pboxPlatno.Height - pboxPlatno.Height * (ground * 0.01)) Then
    snow.RemoveAt(i)
   Else
    snow(i) = New PointF(snow(i).X + r.NextDouble() * 2 - 1 + tbarWind.Value * 0.04, snow(i).Y + r.Next(1, 5))
    i += 1
   End If
  Loop
  pboxPlatno.Refresh()
 End Sub

 Private Sub pboxPlatno_Click(sender As Object, e As EventArgs) Handles pboxPlatno.Click
  tmrTime.Enabled = Not tmrTime.Enabled

 End Sub

 Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
  If e.KeyCode = Keys.Space Then
   tmrTime.Enabled = Not tmrTime.Enabled
  End If
 End Sub
End Class
