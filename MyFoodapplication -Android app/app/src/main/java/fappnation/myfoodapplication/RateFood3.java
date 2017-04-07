package fappnation.myfoodapplication;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;

public class RateFood3 extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_rate_food3);
        Button Next1 =(Button)findViewById(R.id.Next1);
        final ImageButton star1 = (ImageButton) findViewById(R.id.star1);
        final ImageButton star2 = (ImageButton) findViewById(R.id.star2);
        final ImageButton star5 = (ImageButton) findViewById(R.id.star3);
        final ImageButton star4 = (ImageButton) findViewById(R.id.star4);
        final ImageButton star3 = (ImageButton) findViewById(R.id.star5);
        star1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                star1.setSelected(!star1.isPressed());

                if (star1.isPressed()) {
                    star1.setImageResource(R.drawable.stargold);


                    star2.setImageResource(R.drawable.starwhite);
                    star3.setImageResource(R.drawable.starwhite);
                    star4.setImageResource(R.drawable.starwhite);
                    star5.setImageResource(R.drawable.starwhite);
                } else {
                    star1.setImageResource(R.drawable.starwhite);
                }
            }
        });

        star2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                star2.setSelected(!star2.isPressed());

                if (star2.isPressed()) {
                    star2.setImageResource(R.drawable.stargold);
                    star1.setImageResource(R.drawable.stargold);


                    star3.setImageResource(R.drawable.starwhite);
                    star4.setImageResource(R.drawable.starwhite);
                    star5.setImageResource(R.drawable.starwhite);
                } else {
                    star1.setImageResource(R.drawable.starwhite);
                    star2.setImageResource(R.drawable.starwhite);
                    star3.setImageResource(R.drawable.starwhite);
                    star4.setImageResource(R.drawable.starwhite);
                    star5.setImageResource(R.drawable.starwhite);
                }
            }
        });
        star3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                star3.setSelected(!star3.isPressed());

                if (star3.isPressed()) {
                    star1.setImageResource(R.drawable.stargold);
                    star2.setImageResource(R.drawable.stargold);
                    star3.setImageResource(R.drawable.stargold);


                    star4.setImageResource(R.drawable.starwhite);
                    star5.setImageResource(R.drawable.starwhite);
                } else {
                    star1.setImageResource(R.drawable.starwhite);
                    star2.setImageResource(R.drawable.starwhite);
                    star3.setImageResource(R.drawable.starwhite);
                    star4.setImageResource(R.drawable.starwhite);
                    star5.setImageResource(R.drawable.starwhite);
                }
            }
        });
        star4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                star4.setSelected(!star4.isPressed());

                if (star4.isPressed()) {
                    star1.setImageResource(R.drawable.stargold);
                    star2.setImageResource(R.drawable.stargold);
                    star3.setImageResource(R.drawable.stargold);
                    star4.setImageResource(R.drawable.stargold);


                    star5.setImageResource(R.drawable.starwhite);
                } else {
                    star1.setImageResource(R.drawable.starwhite);
                    star2.setImageResource(R.drawable.starwhite);
                    star3.setImageResource(R.drawable.starwhite);
                    star4.setImageResource(R.drawable.starwhite);
                    star5.setImageResource(R.drawable.starwhite);
                }
            }
        });
        star5.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                star5.setSelected(!star5.isPressed());
                if (star5.isPressed()) {
                    star1.setImageResource(R.drawable.stargold);
                    star2.setImageResource(R.drawable.stargold);
                    star3.setImageResource(R.drawable.stargold);
                    star4.setImageResource(R.drawable.stargold);
                    star5.setImageResource(R.drawable.stargold);
                } else {
                    star2.setImageResource(R.drawable.starwhite);
                    star1.setImageResource(R.drawable.starwhite);
                    star3.setImageResource(R.drawable.starwhite);
                    star4.setImageResource(R.drawable.starwhite);
                    star5.setImageResource(R.drawable.starwhite);
                }
            }
        });
        Next1.setOnClickListener(
                new Button.OnClickListener(){
                    public void onClick(View v){
                        startActivity(new Intent(RateFood3.this, RateFood4.class));
                    }
                }
        );
    }
}
