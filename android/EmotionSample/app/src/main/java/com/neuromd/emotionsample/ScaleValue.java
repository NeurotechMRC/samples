package com.neuromd.emotionsample;

public class ScaleValue {
    private final String mLabel;
    private final int mScaleValue;

    ScaleValue(String label, int scaleValue) {
        mLabel = label;
        mScaleValue = scaleValue;
    }

    public String getLabel() {
        return mLabel;
    }
    public int getScaleValue() {
        return mScaleValue;
    }
}