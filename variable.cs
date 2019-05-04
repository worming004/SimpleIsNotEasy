public class Variable {
    private readonly IRepository _r;
    /// [...]
    public void UpdateNameOfItem (int i, string n) {
        var si = _r.GetItem (i);
        si.Name = n;
        _r.Save (si);
    }
}