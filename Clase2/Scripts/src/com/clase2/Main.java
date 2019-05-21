package com.clase2;

import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {

        IShell shell = new PowerShell();

        IScript backup = new BackupScript(shell);
        backup.execute();

        IScript restore = new RestoreScript(shell);
        restore.execute();

        ArrayList<IScript> scripts = new ArrayList<>();
        scripts.add(backup);
        scripts.add(restore);

        IScript scriptExecutor = new ScriptExecutor(scripts);
        scriptExecutor.execute();
    }
}

interface IScript {
    void execute();
    // void unExecute();
    // void do();
    // void undo();

}

class CualquierCosa implements IScript {

    // private CualquierClase cualquierClase;

    //public CalquierCosara(CualquierClase cualquierClase) {
    //  this.cualquierClase = cualquierClase
    //}

    @Override
    public void execute() {
        // this.cualquierClase.blah();
    }
}

class ScriptExecutor implements IScript {

    private ArrayList<IScript> scripts;

    public ScriptExecutor(ArrayList<IScript> scripts) {
        this.scripts = scripts;
    }

    @Override
    public void execute() {
        for (IScript script : scripts) {
            script.execute();
        }
    }
}

class BackupScript implements IScript {

    private IShell shell;

    public BackupScript(IShell shell) {
        this.shell = shell;
    }

    @Override
    public void execute() {
        System.out.println("Backuping...");
        // Crear un backup
        shell.zip();
        shell.copy();
        shell.delete();
    }
}

class RestoreScript implements IScript {

    private IShell shell;

    public RestoreScript(IShell shell) {
        this.shell = shell;
    }

    @Override
    public void execute() {
        System.out.println("Restoring...");
        // Realizar un restore
        shell.unzip();
        shell.copy();
        shell.delete();
    }
}

interface IShell {
    void copy();
    void zip();
    void delete();
    void unzip();
}

class Terminal implements IShell {

    @Override
    public void copy() {
        System.out.println("Copying...");
    }

    @Override
    public void zip() {
        System.out.println("Zipping...");
    }

    @Override
    public void delete() {
        System.out.println("Deleting...");
    }

    @Override
    public void unzip() {
        System.out.println("Unzipping...");
    }
}

class PowerShell implements IShell {

    @Override
    public void copy() {
        System.out.println("Copying...");
    }

    @Override
    public void zip() {
        System.out.println("Zipping...");
    }

    @Override
    public void delete() {
        System.out.println("Deleting...");
    }

    @Override
    public void unzip() {
        System.out.println("Unzipping...");
    }
}