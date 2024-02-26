public readonly struct Marvel {
    public String CharacterName {get;}
    public void PrintCharacterName() {
        Console.WriteLine(CharacterName);
    }

    public Marvel(String CharacterName) {
        this.CharacterName = CharacterName;
    }
}