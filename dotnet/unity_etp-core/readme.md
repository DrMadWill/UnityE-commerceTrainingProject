# Project Core => Entity

### Introduction 
> It is a separate part of the project.We can see the `Database` as a reflection of the `CSharp` code.

### Features 
#### All Model 
- Use BaseEntity Class 
- Use IBaseEntity Interface  
- Use Modify Class 

### Details
- BaseEntity Interface => We use to get the entity base signature.
```cs
    public interface IBaseEntity<TPrimary>
    {
        public TPrimary Id { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public bool IsDelete { get; set; }
    }

```
- Modify Class => We use to apply soft delete.
```cs
    public class Modfiy
    {
        [Column] public DateTime CreateAt { get; set; } = DateTime.Now;
        [Column] public DateTime? UpdateAt { get; set; }
        [Column] public bool IsDelete { get; set; } = false;
    }

```
- BaseEntity Class => We use to gather all the qualifications together.
```cs
    public class BaseEntity<TPrimary> : Modfiy, IBaseEntity<TPrimary>
    {
        public virtual TPrimary Id { get; set; }
    }
``