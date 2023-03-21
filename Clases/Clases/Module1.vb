Module Module1

    Sub Main()

        Dim hyu As AireAcondicionado = New AireAcondicionado("hyu", "hy22ac", "azul", 1000, 0)

        Console.WriteLine("Marca: " & hyu.getMarca)
        Console.WriteLine("Modelo: " & hyu.getModelo)
        Console.WriteLine("Color: " & hyu.getColor)
        Console.WriteLine("Voltaje: " & hyu.getVoltaje)
        Console.WriteLine("Temperatura: " & hyu.getTemperatura)

        hyu.subirTemperatura()
        hyu.subirTemperatura()
        hyu.subirTemperatura(40)
        hyu.bajarTemperatura(40)

        Console.WriteLine("Temperatura: " & hyu.getTemperatura)

        Console.WriteLine(" ")

        Dim sams As AireAcondicionado = New AireAcondicionado("sams", "sa22ac", "verde", 2000, 0)

        Console.WriteLine("Marca: " & sams.getMarca)
        Console.WriteLine("Modelo: " & sams.getModelo)
        Console.WriteLine("Color: " & sams.getColor)
        Console.WriteLine("Voltaje: " & sams.getVoltaje)
        Console.WriteLine("Temperatura: " & sams.getTemperatura)

        Console.WriteLine(" ")

        Dim volador As AireAcondicionado = New AireAcondicionado("volador3000", "hyperbest", "negro")

        Console.WriteLine("Marca: " & volador.getMarca)
        Console.WriteLine("Modelo: " & volador.getModelo)
        Console.WriteLine("Color: " & volador.getColor)

        Console.WriteLine(" ")

        Dim alumno As Alumno = New Alumno("Juan")
        Dim alumno1 As Alumno = New Alumno("Lucia")
        Dim alumno2 As Alumno = New Alumno("Hugo")

        Console.WriteLine(alumno.getIdAlumno() & " " & alumno.getNombre())
        Console.WriteLine(alumno1.getIdAlumno() & " " & alumno1.getNombre())
        Console.WriteLine(alumno2.getIdAlumno() & " " & alumno2.getNombre())

        Console.WriteLine(" ")

        Console.WriteLine(Matematicas.potenciacion(5, 3))
        Console.WriteLine(Math.Pow(5, 3))

    End Sub

End Module
