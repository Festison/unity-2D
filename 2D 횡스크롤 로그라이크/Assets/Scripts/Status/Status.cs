public class Status
{
    public UnitCode unitCode { get; } // 바꿀 수 없게 get만
    public string name { get; set; }
    public int maxHp { get; set; }
    public int nowHp { get; set; }
    public int atkDmg { get; set; }
    public float atkSpeed { get; set; }
    public float moveSpeed { get; set; }
    public float atkRange { get; set; }
    public float fieldOfVision { get; set; }

    public Status()
    {
    }

    public Status(UnitCode unitCode, string name, int maxHp, int atkDmg, float atkSpeed, float moveSpeed, float atkRange, float fieldOfVision)
    {
        this.unitCode = unitCode;
        this.name = name;
        this.maxHp = maxHp;
        nowHp = maxHp;
        this.atkDmg = atkDmg;
        this.atkSpeed = atkSpeed;
        this.moveSpeed = moveSpeed;
        this.atkRange = atkRange;
        this.fieldOfVision = fieldOfVision;
    }

    public Status SetUnitStatus(UnitCode unitCode)
    {
        Status status = null;

        switch (unitCode)
        {
            case UnitCode.Player:
                status = new Status(unitCode, "플레이어", 50, 10, 1f, 8f, 0, 0);
                break;
            case UnitCode.enemy1:
                status = new Status(unitCode, "적", 100, 12, 1.5f, 2f, 1.5f, 7f);
                break;
        }
        return status;
    }
}
