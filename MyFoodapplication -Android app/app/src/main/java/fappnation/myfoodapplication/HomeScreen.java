package fappnation.myfoodapplication;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class HomeScreen extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_home_screen);
        Button SignInMain3 =(Button)findViewById(R.id.button3);
        Button RegisterMain3 =(Button)findViewById(R.id.button2);

        RegisterMain3.setOnClickListener(
                new Button.OnClickListener(){
                    public void onClick(View v){
                        startActivity(new Intent(HomeScreen.this, SignUp.class));
                    }
                }
        );
        SignInMain3.setOnClickListener(
                new Button.OnClickListener(){
                    public void onClick(View v){
                        startActivity(new Intent(HomeScreen.this, LoginScreen.class));
                    }
                }
        );
    }
}
