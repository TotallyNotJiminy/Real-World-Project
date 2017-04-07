package fappnation.myfoodapplication;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class LoginScreen extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login_screen);


        Button SignInMain =(Button)findViewById(R.id.Signin1);
        Button RegisterMain =(Button)findViewById(R.id.Register1);

        RegisterMain.setOnClickListener(
                new Button.OnClickListener(){
                    public void onClick(View v){
                        startActivity(new Intent(LoginScreen.this, SignUp.class));
                    }
                }
        );
        SignInMain.setOnClickListener(
                new Button.OnClickListener(){
                    public void onClick(View v){
                        startActivity(new Intent(LoginScreen.this, Navigation.class));
                    }
                }
        );
    }
}
