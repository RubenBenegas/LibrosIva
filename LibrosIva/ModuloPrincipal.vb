Module ModuloPrincipal
    Public lst As ContribuyentesCollection
    Public lstCompras As ComprasCollection

    Sub main()

        lst = New ContribuyentesCollection
        lstCompras = New ComprasCollection

        Application.Run(MenuForm)

    End Sub
End Module
