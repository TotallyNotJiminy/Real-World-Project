package fappnation.myfoodapplication;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class Youredone extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_youredone);
        Button Proceed1 =(Button)findViewById(R.id.Next1);
        Proceed1.setOnClickListener(
                new Button.OnClickListener(){
                    public void onClick(View v) {
                        startActivity(new Intent(Youredone.this, Navigation.class));
                    }
    }
                    );
}
    }